using PictureManagerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solutieWCF
{
    public class MyBd : IMyBd
    {
        //--------------------Media

        public bool CreateMedia(string pathName)
        {
            MediaI media = new MediaI();
            return media.CreateMedia(pathName);
        }

        public bool DeleteMedia(string mediaPath)
        {
            MediaI media = new MediaI();
            return media.DeleteMedia(mediaPath);
        }

        public bool DeleteMedia(Media media)
        {
            MediaI newMedia = new MediaI();
            return newMedia.DeleteMedia(media);
        }

        public List<Media> GetAllMedia()
        {
            MediaI newMedia = new MediaI();
            return newMedia.GetAllMedia();
        }

        public List<Media> GetAllMedia(int media)
        {
            MediaI newMedia = new MediaI();
            return newMedia.GetAllMedia(media);
        }

        public List<Media> GetAllMedia(string mediaName)
        {
            MediaI newMedia = new MediaI();
            return newMedia.GetAllMedia(mediaName);
        }

        public Media GetMedia(string mediaPath)
        {
            MediaI newMedia = new MediaI();
            return newMedia.GetMedia(mediaPath);
        }

        public Media GetMedia(int mediaID)
        {
            MediaI newMedia = new MediaI();
            return newMedia.GetMedia(mediaID);
        }

        public int GetMediaId(string mediaPath)
        {
            MediaI newMedia = new MediaI();
            return newMedia.GetMediaId(mediaPath);
        }

        public bool UpdateMedia(Media newMedia)
        {
            MediaI media = new MediaI();
            return media.UpdateMedia(newMedia);
        }

        //----------------------Tag

        public Tags CreateDateTag(string date)
        {
            Tag newTag = new Tag();
            return newTag.CreateDateTag(date);

        }

        public bool CreateTag(string valueOfTag)
        {
            Tag newTag = new Tag();
            return newTag.CreateTag(valueOfTag);

        }

        public Tags CreateTagAnReturnTag(string valueOfTag)
        {
            Tag newTag = new Tag();
            return newTag.CreateTagAnReturnTag(valueOfTag);
        }

        public bool DeleteTag(Tags deletedTag)
        {
            Tag tag = new Tag();
            return tag.DeleteTag(deletedTag);
        }

        public Tags GetTag(string givenTagValue)
        {
            Tag tag = new Tag();
            return tag.GetTag(givenTagValue);
        }

        public List<Tags> GetTagAll()
        {
            Tag tag = new Tag();
            return tag.GetTagAll();
        }

        public bool UpdateTag(Tags updatedTag)
        {
            Tag tag = new Tag();
            return tag.UpdateTag(updatedTag);
        }

    //------------------TagType
    public bool Create(string valueOfTag)
        {
            TagTypes newTagType = new TagTypes();
            return newTagType.Create(valueOfTag);
        }

        public TagType CreateAndReturn(string valueOfTag)
        {
            TagTypes newTagType = new TagTypes();
            return newTagType.CreateAndReturn(valueOfTag);
        }

        public TagType CreateTagTypeAndReturnIt(string valueOfTag)
        {
            TagTypes tagType = new TagTypes();
            return tagType.CreateTagTypeAndReturnIt(valueOfTag);
        }

        public bool DeleteTagType(TagType givenTagType)
        {
            return DeleteTagType(givenTagType);
        }

        public TagType GetTagTypes(int givenId)
        {
            return GetTagTypes(givenId);
        }

        public TagType GetTagTypes(string givenValueTagType)
        {
            return GetTagTypes(givenValueTagType);
        }

        public bool UpdateTagType(TagType newTagType)
        {
            return UpdateTagType(newTagType);
        }
        //-------------------TableWay
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
