using PictureManagerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.Entity;

namespace solutieWCF
{
    public class MyBd : IMyBd
    {
        //--------------------Media

        public bool CreateMedia(string pathName)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                Media newMedia = new Media();
                newMedia.Media_path = pathName;
                newMedia.Media_name = Path.GetFileName(pathName);
                try
                {
                    MyBd.Media.Add(newMedia);
                    MyBd.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }

                return true;
            };
        }

        public bool DeleteMedia(string mediaPath)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                try
                {
                    Media media = MyBd.Media.Where(mediaDB => mediaDB.Media_path == mediaPath && mediaDB.Is_Deleted != true).ToList()[0];
                    MyBd.Media.Attach(media);
                    media.Is_Deleted = true;
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

        public bool DeleteMedia(Media media)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                try
                {
                    MyBd.Media.Where(mediaDB => mediaDB.Id_Media == media.Id_Media && mediaDB.Is_Deleted != true).FirstOrDefault().Is_Deleted = true;
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

        public List<Media> GetAllMedia()
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                return MyBd.Media.Where(media => media.Is_Deleted != true).Include("TableWays").Include("TableWays.Tag").Include("TableWays.TagType").ToList();
            };
        }

        public List<Media> GetAllMedia(int media)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                List<Media> x = MyBd.Media.Where(mediaDB => mediaDB.Id_Media == media && mediaDB.Is_Deleted != true).Include("TableWays").Include("TableWays.Tag").Include("TableWays.TagType").ToList();
                return x;
            };

        }

        public List<Media> GetAllMedia(string mediaName)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                List<Media> x = MyBd.Media.Where(media => media.Media_name == mediaName && media.Is_Deleted != true).Include("TableWays").Include("TableWays.Tag").Include("TableWays.TagType").ToList();
                return x;
            };
        }

        public Media GetMedia(string mediaPath)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                Media x = MyBd.Media.Where(media => media.Media_path == mediaPath && media.Is_Deleted != true).Include("TableWays").Include("TableWays.Tag").Include("TableWays.TagType").ToList()[0];
                return x;
            };
        }

        public Media GetMedia(int mediaID)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                Media x = MyBd.Media.Where(media => media.Id_Media == mediaID && media.Is_Deleted != true).Include("TableWays").Include("TableWays.Tag").Include("TableWays.TagType").FirstOrDefault();
                return x;
            };
        }

        public int GetMediaId(string mediaPath)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                int x = MyBd.Media.Where(media => media.Media_path == mediaPath && media.Is_Deleted != true).Include(mediaDB => mediaDB.TableWays).FirstOrDefault().Id_Media;
                return x;
            };
        }

        public bool UpdateMedia(Media newMedia)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                try
                {
                    MyBd.Media.Attach(newMedia);
                }
                catch
                {
                    return false;
                }
                MyBd.SaveChanges();
                return true;
            };
        }
    

    //----------------------Tag
    public List<Tags> GetTag(int tableWayId)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                try
                {
                    //var tagsId = MyBd.TableWays.Where(table => table.Id == tableWayId && table.Is_Deleted != true).ToList()[0];
                    //return MyBd.Tags.Where(tag => tag.Id_Tags == tagsId.Tag.Id_Tags && tag.Is_Deleted != true).ToList();
                    return (from item in MyBd.TableWays where item.Id == tableWayId select item.Tag).ToList();
                }
                catch
                {
                    return null;
                }
            };
        }
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
                    return MyBd.Tags.Where(tag => tag.Value_tag == givenTagValue && tag.Is_Deleted != true).ToList()[0];
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
                return MyBd.Tags.Where(tag => tag.Is_Deleted != true).ToList();
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

        //------------------TagType
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
                    return MyBd.TagTypes.Where(tagTpye => tagTpye.Id_TagType == givenId && tagTpye.Is_Deleted != true).FirstOrDefault();
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
                    return MyBd.TagTypes.Where(tagTpye => tagTpye.Value_tagType == givenValueTagType && tagTpye.Is_Deleted != true).FirstOrDefault();

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

        //-------------------TableWay
        public bool CreateTableWay(Media media, Tags tag, TagType tagType)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                try
                {
                    TableWays tableWay = new TableWays();
                    tableWay.Medium = media;
                    tableWay.Tag = tag;
                    tableWay.TagType = tagType;
                    MyBd.TableWays.Add(tableWay);
                    MyBd.SaveChanges();
                }
                catch
                {
                    return false;
                }
                return true;
            };
        }

        public bool DeleteTableWay(Media media)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                try
                {
                    MyBd.TableWays.Where(var => var.Medium.Id_Media == media.Id_Media && var.Is_Deleted != true).FirstOrDefault().Is_Deleted = true;
                    MyBd.SaveChanges();
                }
                catch
                {
                    return false;
                }
                return true;
            };
        }

        public List<TableWays> GetTableWays(Media media)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                try
                {
                    return MyBd.TableWays.Where(tableWay => tableWay.Medium == media && tableWay.Is_Deleted != true).ToList();
                }
                catch
                {
                    return null;
                }
            };
        }

        public List<int> GetTableWaysIdMediaAfterIdTag(int tagId)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                try
                {
                    var objectTableWay = MyBd.TableWays.Where(category => category.Tag.Id_Tags == tagId && category.Tag.Is_Deleted != true).ToList();
                    List<int> returnable = new List<int>();
                    foreach (var item in objectTableWay)
                    {
                        returnable.Add(item.Medium.Id_Media);
                    }
                    return returnable;
                }
                catch
                {
                    return null;
                }
            };
        }

        public List<int> GetTableWaysIdMediaAfterIdTagType(int tagTypeId)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                try
                {
                    var objectTableWay = MyBd.TableWays.Where(category => category.TagType.Id_TagType == tagTypeId && category.TagType.Is_Deleted != true).ToList();
                    List<int> returnable = new List<int>();
                    foreach (var item in objectTableWay)
                    {
                        returnable.Add(item.Medium.Id_Media);
                    }
                    return returnable;
                }
                catch
                {
                    return null;
                }
            };
        }

        public int GetTableWaysIdTagsCategory(int tagId)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                try
                {
                    var objectTableWay = MyBd.TableWays.Where(category => category.Tag.Id_Tags == tagId && category.Tag.Is_Deleted != true).FirstOrDefault();
                    return objectTableWay.TagType.Id_TagType;
                }
                catch
                {
                    return 0;
                }
            };
        }

        public Tags GetTableWaysIdTagsCategoryForDATE(int mediaId)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                try
                {
                    List<TableWays> objectTableWay = MyBd.TableWays.Where(category => category.Medium.Id_Media == mediaId && category.Tag.Is_Deleted != true).ToList();
                    foreach (var item in objectTableWay)
                    {
                        if (item.TagType.Value_tagType == "Date")
                        {
                            return item.Tag;
                        }
                    }
                    //return objectTableWay.TagType.Value_tagType;
                }
                catch
                {
                    return null;
                }
                return null;
            };
        }

        public int GetTableWaysTagsId(int mediaId)
        {
            using (var MyBd = new ModelDBPicturesManagerContainer())
            {
                try
                {
                    var objectTableWay = MyBd.TableWays.Find(mediaId);
                    return objectTableWay.Tag.Id_Tags;
                }
                catch
                {
                    return 0;
                }
            };
        }
    }

}
