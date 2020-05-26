using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceMedia;
using WebAppl.Models;

namespace WebAppl
{
    public class DetailsModel : PageModel
    {
        public MyBdClient myBdClient = new MyBdClient();
        public Media media;
        
        //public List<int> tableWay = new List<int>();


        public async Task OnGetAsync(string id)
            {
            //System.Diagnostics.Debug.WriteLine(id);
            int useId = Int32.Parse(id);
            media  = await myBdClient.GetMediaByIdAsync(useId);

        }
            
        
    }
}