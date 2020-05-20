using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureManagerLibrary
{
    public static class TagsLibraryFunctions
    {
        public static Boolean CreateTag(string valueOfTag)
        {
            Tags tag = new Tags();
            tag.Value_tag = valueOfTag;
            try
            {

                ContextDBLibrary.Context.Tags.Add(tag);
                ContextDBLibrary.Context.SaveChanges();

            }
            catch
            {
                return false;
            }
            return true;
        }

        public static Tags CreateDateTag(string date)
        {
            Tags tag = new Tags();
            tag.Value_tag = date;
            try
            {

                ContextDBLibrary.Context.Tags.Add(tag);
                ContextDBLibrary.Context.SaveChanges();
               
            }
            catch
            {
                return null ;
            }
            return tag;
           
        }
        public static Tags CreateTagAnReturnTag(string valueOfTag)
        {
            Tags tag = new Tags();
            tag.Value_tag = valueOfTag;
            try
            {

                ContextDBLibrary.Context.Tags.Add(tag);
                ContextDBLibrary.Context.SaveChanges();
                return tag;

            }
            catch
            {
                return null;
            }
           
        }

        public static Boolean DeleteTag(Tags deletedTag)
        {
            try 
            {
                deletedTag.Is_Deleted = true;
                ContextDBLibrary.Context.SaveChanges();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }

        public static Boolean UpdateTag(Tags updatedTag)
        {
            try
            {
                ContextDBLibrary.Context.Tags.Where(variable => variable.Id_Tags==updatedTag.Id_Tags && variable.Is_Deleted!=true).FirstOrDefault().Value_tag=updatedTag.Value_tag;
                ContextDBLibrary.Context.SaveChanges();
            }
            catch
            {
                return false;
            }
            
            return true;
        }

        //public static Tags GetTag(int givenTagId)
        //{
        //    try
        //    {
        //        return ContextDBLibrary.Context.Tags.Find(givenTagId);
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}
        public static Tags GetTag(string givenTagValue)
        {
            try
            {
                return ContextDBLibrary.Context.Tags.Where(tag => tag.Value_tag == givenTagValue && tag.Is_Deleted!=true).ToList()[0];
            }
            catch
            {
                return null;
            }
        }

        public static List<Tags> GetTagAll()
        {
            return ContextDBLibrary.Context.Tags.Where(tag => tag.Is_Deleted != true).ToList();
        }

        
           
        
    }
}
