using PictureManagerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace solutieWCF
{
    [ServiceContract]
    public interface InterfaceMedia
    {
        [OperationContract]
        Boolean CreateMedia(String pathName);
        [OperationContract(Name ="DeleteMediaByPath")]
        Boolean DeleteMedia(String mediaPath);
        [OperationContract(Name = "DeleteMediaByMedia")]
        Boolean DeleteMedia(Media media);
        [OperationContract]
        Boolean UpdateMedia(Media newMedia);
        [OperationContract(Name = "GetMediaByPath")]
        Media GetMedia(String mediaPath);
        [OperationContract(Name = "GetMediaById")]
        Media GetMedia(int mediaID);
        [OperationContract]
        int GetMediaId(String mediaPath);
        [OperationContract(Name = "GetAllMedia")]
        List<Media> GetAllMedia();
        [OperationContract(Name = "GetAllMediaByMediaId")]
        List<Media> GetAllMedia(int media);
        [OperationContract(Name = "GetAllMediaByName")]
        List<Media> GetAllMedia(string mediaName);
    }

    [ServiceContract]
    public interface InterfaceTag
    {
        [OperationContract]
        Boolean CreateTag(string valueOfTag);
        [OperationContract]
        Tags CreateDateTag(string date);
        [OperationContract]
        Tags CreateTagAnReturnTag(string valueOfTag);
        [OperationContract]
        Boolean DeleteTag(Tags deletedTag);
        [OperationContract]
        Boolean UpdateTag(Tags updatedTag);
        [OperationContract]
        Tags GetTag(string givenTagValue);
        [OperationContract]
        List<Tags> GetTagAll();
    }

    [ServiceContract]
    public interface InterfaceTagTypes 
    {
        [OperationContract]
        Boolean Create(string valueOfTag);
        [OperationContract]
        TagType CreateAndReturn(string valueOfTag);
        [OperationContract]
        TagType CreateTagTypeAndReturnIt(string valueOfTag);
        [OperationContract]
        Boolean DeleteTagType(TagType givenTagType);
        [OperationContract]
        Boolean UpdateTagType(TagType newTagType);
        [OperationContract(Name = "GetTagTypeById")]
        TagType GetTagTypes(int givenId);
        [OperationContract(Name = "GetTagTypeByString")]
        TagType GetTagTypes(string givenValueTagType);
        
    }

    [ServiceContract]
    public interface InterfataTableWay
    {
        [OperationContract]
        Boolean CreateTableWay(Media media, Tags tag, TagType tagType);
        [OperationContract]
        Boolean DeleteTableWay(Media media);
        [OperationContract]
        List<TableWays> GetTableWays(Media media);
        [OperationContract]
        int GetTableWaysTagsId(int mediaId);
        [OperationContract]
        int GetTableWaysIdTagsCategory(int tagId);
        [OperationContract]
        Tags GetTableWaysIdTagsCategoryForDATE(int mediaId);
        [OperationContract]
        List<int> GetTableWaysIdMediaAfterIdTagType(int tagTypeId);
        [OperationContract]
        List<int> GetTableWaysIdMediaAfterIdTag(int tagId);
    }

    [ServiceContract]
    public interface IMyBd : InterfaceMedia, InterfaceTag, InterfaceTagTypes, InterfataTableWay
    {
    }
}
