using PictureManagerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solutieWCF
{
    public class TagTypes : InterfaceTagTypes
    {
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
    }
}