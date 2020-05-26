using PictureManagerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace solutieWCF
{
    public class MediaI : InterfaceMedia
    {
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
    }
}
