using PictureManagerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solutieWCF
{
    public class Tag : InterfaceTag
    {
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
    }
}
