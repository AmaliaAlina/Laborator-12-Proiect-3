using PictureManagerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solutieWCF
{
    public class MediaI : InterfaceMedia
    {
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
    }
}
