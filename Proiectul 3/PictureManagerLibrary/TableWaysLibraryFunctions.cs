using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureManagerLibrary
{
    public static class TableWaysLibraryFunctions
    {

        public static Boolean CreateTableWay(Media media, Tags tag, TagType tagType)
        {
            try
            {
                TableWays tableWay = new TableWays();
                tableWay.Medium = media;
                tableWay.Tag = tag;
                tableWay.TagType = tagType;
                ContextDBLibrary.Context.TableWays.Add(tableWay);
                ContextDBLibrary.Context.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static Boolean DeleteTableWay(Media media)
        {
            try
            {
                ContextDBLibrary.Context.TableWays.Where(var => var.Medium.Id_Media == media.Id_Media && var.Is_Deleted != true).FirstOrDefault().Is_Deleted = true;
                ContextDBLibrary.Context.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static List<TableWays> GetTableWays(Media media)
        {
            try 
            { 
                return ContextDBLibrary.Context.TableWays.Where(tableWay => tableWay.Medium == media && tableWay.Is_Deleted != true).ToList();
            }
            catch
            {
                return null;
            }
        }

        public static int GetTableWaysTagsId(int mediaId)
        {
            try
            {
                var objectTableWay = ContextDBLibrary.Context.TableWays.Find(mediaId);
                return objectTableWay.Tag.Id_Tags;
            }
            catch
            {
                return 0;
            }
        }
        public static int GetTableWaysIdTagsCategory(int tagId)
        {
            try
            {
                var objectTableWay = ContextDBLibrary.Context.TableWays.Where(category => category.Tag.Id_Tags==tagId && category.Tag.Is_Deleted!= true).FirstOrDefault();
                return objectTableWay.TagType.Id_TagType;
            }
            catch
            {
                return 0;
            }
        }

        public static Tags GetTableWaysIdTagsCategoryForDATE(int mediaId)
        {
            try
            {
                List<TableWays> objectTableWay = ContextDBLibrary.Context.TableWays.Where(category => category.Medium.Id_Media == mediaId && category.Tag.Is_Deleted != true).ToList() ;
                foreach(var item in objectTableWay)
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
                return null ;
            }
            return null;
        }
        public static List<int> GetTableWaysIdMediaAfterIdTagType(int tagTypeId)
        {
            try
            {
                var objectTableWay = ContextDBLibrary.Context.TableWays.Where(category => category.TagType.Id_TagType == tagTypeId && category.TagType.Is_Deleted != true).ToList();
                List<int> returnable = new List<int>();
                foreach(var item in objectTableWay)
                {
                    returnable.Add(item.Medium.Id_Media);
                }
                return returnable;
            }
            catch
            {
                return null;
            }
        }
        public static List<int> GetTableWaysIdMediaAfterIdTag(int tagId)
        {
            try
            {
                var objectTableWay = ContextDBLibrary.Context.TableWays.Where(category => category.Tag.Id_Tags == tagId && category.Tag.Is_Deleted != true).ToList();
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
        }
    }
}
