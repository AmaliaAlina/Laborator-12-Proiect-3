using PictureManagerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solutieWCF
{
    public class TableWay : InterfataTableWay
    {
        public bool CreateTableWay(Media media, Tags tag, TagType tagType)
        {
            TableWay tableWay = new TableWay();
            return tableWay.CreateTableWay(media, tag, tagType);
        }

        public bool DeleteTableWay(Media media)
        {
            TableWay tableWay = new TableWay();
            return tableWay.DeleteTableWay(media);
        }

        public List<TableWays> GetTableWays(Media media)
        {
            TableWay tableWay = new TableWay();
            return tableWay.GetTableWays(media);
        }

        public List<int> GetTableWaysIdMediaAfterIdTag(int tagId)
        {
            TableWay tableWay = new TableWay();
            return tableWay.GetTableWaysIdMediaAfterIdTag(tagId);
        }

        public List<int> GetTableWaysIdMediaAfterIdTagType(int tagTypeId)
        {
            TableWay tableWay = new TableWay();
            return tableWay.GetTableWaysIdMediaAfterIdTagType(tagTypeId);
        }

        public int GetTableWaysIdTagsCategory(int tagId)
        {
            TableWay tableWay = new TableWay();
            return tableWay.GetTableWaysIdTagsCategory(tagId);
        }

        public Tags GetTableWaysIdTagsCategoryForDATE(int mediaId)
        {
            TableWay tableWay = new TableWay();
            return tableWay.GetTableWaysIdTagsCategoryForDATE(mediaId);
        }

        public int GetTableWaysTagsId(int mediaId)
        {
            TableWay tableWay = new TableWay();
            return tableWay.GetTableWaysTagsId(mediaId);
        }
    }
}
