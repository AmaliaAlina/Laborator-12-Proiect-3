using PictureManagerLibrary;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solutieWCF
{
    public class TableWay : InterfataTableWay
    {
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
                    return MyBd.TableWays.Where(tableWay => tableWay.Medium == media && tableWay.Is_Deleted != true).Include(tableWay => tableWay.Tag).Include(tableWay => tableWay.Medium).Include(tableWay => tableWay.TagType).ToList();
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
                    var objectTableWay = MyBd.TableWays.Where(category => category.Tag.Id_Tags == tagId && category.Tag.Is_Deleted != true).Include(tableWay => tableWay.Tag).Include(tableWay => tableWay.Medium).Include(tableWay => tableWay.TagType).ToList();
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
                    var objectTableWay = MyBd.TableWays.Where(category => category.TagType.Id_TagType == tagTypeId && category.TagType.Is_Deleted != true).Include(tableWay => tableWay.Tag).Include(tableWay => tableWay.Medium).Include(tableWay => tableWay.TagType).ToList();
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
                    var objectTableWay = MyBd.TableWays.Where(category => category.Tag.Id_Tags == tagId && category.Tag.Is_Deleted != true).Include(tableWay => tableWay.Tag).Include(tableWay => tableWay.Medium).Include(tableWay => tableWay.TagType).FirstOrDefault();
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
                    List<TableWays> objectTableWay = MyBd.TableWays.Where(category => category.Medium.Id_Media == mediaId && category.Tag.Is_Deleted != true).Include(tableWay => tableWay.Tag).Include(tableWay => tableWay.Medium).Include(tableWay => tableWay.TagType).ToList();
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
                    var objectTableWay = MyBd.TableWays.Where(tableWay => tableWay.Medium.Id_Media == mediaId && tableWay.Is_Deleted != true).Include(tableWay => tableWay.Tag).Include(tableWay => tableWay.Medium).Include(tableWay => tableWay.TagType).FirstOrDefault();
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
