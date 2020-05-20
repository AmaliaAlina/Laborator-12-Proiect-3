using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureManagerLibrary
{
    public static class TagTypesLibraryFunctions
    {
        public static Boolean Create(string valueOfTag)
        {
            
            TagType tagType = new TagType();
            tagType.Value_tagType = valueOfTag;

            try
            {
                ContextDBLibrary.Context.TagTypes.Add(tagType);
                ContextDBLibrary.Context.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static TagType CreateAndReturn(string valueOfTag)
        {

            TagType tagType = new TagType();
            tagType.Value_tagType = valueOfTag;

            try
            {
                ContextDBLibrary.Context.TagTypes.Add(tagType);
                ContextDBLibrary.Context.SaveChanges();
            }
            catch
            {
                return null;
            }
            return tagType;
        }
        public static TagType CreateTagTypeAndReturnIt(string valueOfTag)
        {

            TagType tagType = new TagType();
            tagType.Value_tagType = valueOfTag;

            try
            {
                ContextDBLibrary.Context.TagTypes.Add(tagType);
                ContextDBLibrary.Context.SaveChanges();
                return tagType;
            }
            catch
            {
                return null;
            }
            
        }
        public static Boolean DeleteTagType(TagType givenTagType)
        {
            try
            {
                ContextDBLibrary.Context.TagTypes.Where(var => var.Id_TagType == givenTagType.Id_TagType && var.Is_Deleted != true).FirstOrDefault().Is_Deleted = true;
                ContextDBLibrary.Context.SaveChanges();
            }
            catch
            {
                return false;
            }

            return true;
        }

        //test mult :)
        public static Boolean UpdateTagType(TagType newTagType)
        {

            try
            {
                ContextDBLibrary.Context.TagTypes.Where(variable => variable.Id_TagType==newTagType.Id_TagType && variable.Is_Deleted!=true).FirstOrDefault().Value_tagType=newTagType.Value_tagType;
                ContextDBLibrary.Context.SaveChanges();
            }
            catch
            {
                return false;
            }
            
            return true;
        }

        public static TagType GetTagTypes(int givenId)
        {
            try
            {
                return ContextDBLibrary.Context.TagTypes.Where(tagTpye => tagTpye.Id_TagType == givenId && tagTpye.Is_Deleted != true).FirstOrDefault();
            }
            catch
            {
                return null;
            }

        }
        public static TagType GetTagTypes(string givenValueTagType)
        {
            try
            {
                return ContextDBLibrary.Context.TagTypes.Where(tagTpye => tagTpye.Value_tagType == givenValueTagType && tagTpye.Is_Deleted != true).FirstOrDefault();

            }
            catch
            {
                return null;
            }

        }
    }
}
