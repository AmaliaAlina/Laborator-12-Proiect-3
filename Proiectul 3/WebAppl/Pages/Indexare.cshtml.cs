using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceMedia;
using WebAppl.Models;

namespace WebAppl 
{
    public class IndexareModel : PageModel
    {

        public MyBdClient myBdClient = new MyBdClient();
        public List<MediaDTO> listMediaDTO { get; set; } 

        public IndexareModel()
        {
             listMediaDTO = new List<MediaDTO>();
         }
    

        public  async Task OnGetAsync()
        {
            var allMedia = await myBdClient.GetAllMediaAsync();
            foreach(var element in allMedia)
            {
                MediaDTO mediaDTO = new MediaDTO();
                mediaDTO.Id_Media = element.Id_Media;
                mediaDTO.Is_Deleted = element.Is_Deleted;
                mediaDTO.Media_name = element.Media_name;
                mediaDTO.Media_path = "PictureManager - DBPictures/" + Path.GetFileName(element.Media_path);
                //mediaDTO.TableWaysDTO = element.TableWays;
                listMediaDTO.Add(mediaDTO);
            }

        }
    }
}