using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureManagerLibrary
{
    public static class MediaLibraryFunctions
    {
        public static Boolean CreateMedia(String pathName)
        {
            Media newMedia = new Media();
            newMedia.Media_path = pathName;
            newMedia.Media_name = Path.GetFileName(pathName);
            try
            {
                ContextDBLibrary.Context.Media.Add(newMedia);
                ContextDBLibrary.Context.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

            return true;
        }
        public static Boolean DeleteMedia(String mediaPath)
        {
            try
            {
                Media media = ContextDBLibrary.Context.Media.Where(mediaDB => mediaDB.Media_path == mediaPath && mediaDB.Is_Deleted != true).ToList()[0];
                ContextDBLibrary.Context.Media.Attach(media);
                media.Is_Deleted = true;
                ContextDBLibrary.Context.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;

        }

        public static Boolean DeleteMedia(Media media)
        {
            try
            {
                ContextDBLibrary.Context.Media.Where(mediaDB => mediaDB.Id_Media == media.Id_Media && mediaDB.Is_Deleted != true).FirstOrDefault().Is_Deleted = true;
                ContextDBLibrary.Context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;

        }
        public static Boolean UpdateMedia(Media newMedia)
        {
            try
            {
                ContextDBLibrary.Context.Media.Attach(newMedia);
            }
            catch
            {
                return false;
            }
            ContextDBLibrary.Context.SaveChanges();
            return true;
        }

        public static Media GetMedia(String mediaPath)
        {
            try
            {
                return ContextDBLibrary.Context.Media.Where(media => media.Media_path == mediaPath && media.Is_Deleted != true).ToList()[0];
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }


        public static Media GetMedia(int mediaID)
        {
            try
            {
                return ContextDBLibrary.Context.Media.Where(media => media.Id_Media == mediaID && media.Is_Deleted != true).FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public static int GetMediaId(String mediaPath)
        {
            try
            {
                 Media mediaUsed= ContextDBLibrary.Context.Media.Where(media => media.Media_path == mediaPath && media.Is_Deleted != true).ToList()[0];
                 return mediaUsed.Id_Media;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }

        public static List<Media> GetAllMedia()
        {
            try
            {
                return ContextDBLibrary.Context.Media.Where(media => media.Is_Deleted!= true).ToList();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public static List<Media> GetAllMedia(int media)
        {
            try
            {
                return ContextDBLibrary.Context.Media.Where(mediaDB =>mediaDB.Id_Media== media && mediaDB.Is_Deleted != true).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
        public static List<Media> GetAllMedia(string mediaName)
        {
            try
            {
                return ContextDBLibrary.Context.Media.Where(media => media.Media_name == mediaName && media.Is_Deleted != true).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

    }
}
