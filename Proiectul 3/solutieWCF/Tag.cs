using PictureManagerLibrary;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solutieWCF
{
    public class Tag : InterfaceTag
    {
        public Tags CreateDateTag(string date)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                Tags tag = new Tags();
                tag.Value_tag = date;
                try
                {

                   MyBd.Tags.Add(tag);
                   MyBd.SaveChanges();

                }
                catch
                {
                    return null;
                }
                return tag;

            };

        }

        public bool CreateTag(string valueOfTag)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                Tags tag = new Tags();
                tag.Value_tag = valueOfTag;
                try
                {

                   MyBd.Tags.Add(tag);
                   MyBd.SaveChanges();

                }
                catch
                {
                    return false;
                }
                return true;
            };
        }

        public Tags CreateTagAnReturnTag(string valueOfTag)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                Tags tag = new Tags();
                tag.Value_tag = valueOfTag;
                try
                {

                   MyBd.Tags.Add(tag);
                   MyBd.SaveChanges();
                    return tag;

                }
                catch
                {
                    return null;
                }
            };
        }

        public bool DeleteTag(Tags deletedTag)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                try
                {
                    deletedTag.Is_Deleted = true;
                   MyBd.SaveChanges();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return false;
                }
                return true;
            };
        }

        public Tags GetTag(string givenTagValue)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                try
                {
                    return MyBd.Tags.Where(tag => tag.Value_tag == givenTagValue && tag.Is_Deleted != true).Include(tagTpye => tagTpye.TableWays).ToList()[0];
                }
                catch
                {
                    return null;
                }
            };
        }
        public List<Tags> GetTag(int tableWayId)
        { 
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                try
                {
                    //var  tagsId= MyBd.TableWays.Where(table => table.Id == tableWayId && table.Is_Deleted != true).ToList()[0];
                    //return MyBd.Tags.Where(tag => tag.Id_Tags == tagsId.Tag.Id_Tags && tag.Is_Deleted != true).ToList();

                    return (from item in MyBd.TableWays where item.Id == tableWayId select item.Tag).ToList();
                }
                catch
                {
                    return null;
                }
            };
        }

        public List<Tags> GetTagAll()
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                return MyBd.Tags.Where(tag => tag.Is_Deleted != true).Include(tagTpye => tagTpye.TableWays).ToList();
            };
        }

        public bool UpdateTag(Tags updatedTag)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                try
                {
                   MyBd.Tags.Where(variable => variable.Id_Tags == updatedTag.Id_Tags && variable.Is_Deleted != true).FirstOrDefault().Value_tag = updatedTag.Value_tag;
                   MyBd.SaveChanges();
                }
                catch
                {
                    return false;
                }

                return true;
            };
        }
    }
}
