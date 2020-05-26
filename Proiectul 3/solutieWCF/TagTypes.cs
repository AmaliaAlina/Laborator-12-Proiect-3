using PictureManagerLibrary;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solutieWCF
{
    public class TagTypes : InterfaceTagTypes
    {
        public bool Create(string valueOfTag)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                TagType tagType = new TagType();
                tagType.Value_tagType = valueOfTag;

                try
                {
                    MyBd.TagTypes.Add(tagType);
                    MyBd.SaveChanges();
                }
                catch
                {
                    return false;
                }
                return true;
            };
        }

        public TagType CreateAndReturn(string valueOfTag)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                TagType tagType = new TagType();
                tagType.Value_tagType = valueOfTag;

                try
                {
                    MyBd.TagTypes.Add(tagType);
                    MyBd.SaveChanges();
                }
                catch
                {
                    return null;
                }
                return tagType;
            };
        }

        public TagType CreateTagTypeAndReturnIt(string valueOfTag)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {

                TagType tagType = new TagType();
                tagType.Value_tagType = valueOfTag;

                try
                {
                    MyBd.TagTypes.Add(tagType);
                    MyBd.SaveChanges();
                    return tagType;
                }
                catch
                {
                    return null;
                }
            };
        }

        public bool DeleteTagType(TagType givenTagType)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                try
                {
                    MyBd.TagTypes.Where(var => var.Id_TagType == givenTagType.Id_TagType && var.Is_Deleted != true).FirstOrDefault().Is_Deleted = true;
                    MyBd.SaveChanges();
                }
                catch
                {
                    return false;
                }

                return true;
            };
        }

        public TagType GetTagTypes(int givenId)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                try
                {
                    return MyBd.TagTypes.Where(tagTpye => tagTpye.Id_TagType == givenId && tagTpye.Is_Deleted != true).Include(tagTpye => tagTpye.TableWays).FirstOrDefault();
                }
                catch
                {
                    return null;
                }
            };
        }

        public TagType GetTagTypes(string givenValueTagType)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                try
                {
                    return MyBd.TagTypes.Where(tagTpye => tagTpye.Value_tagType == givenValueTagType && tagTpye.Is_Deleted != true).Include(tagTpye => tagTpye.TableWays).FirstOrDefault();

                }
                catch
                {
                    return null;
                }
            };
        }

        public bool UpdateTagType(TagType newTagType)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                try
                {
                    MyBd.TagTypes.Where(variable => variable.Id_TagType == newTagType.Id_TagType && variable.Is_Deleted != true).FirstOrDefault().Value_tagType = newTagType.Value_tagType;
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