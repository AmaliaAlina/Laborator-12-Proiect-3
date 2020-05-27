using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceMedia;

namespace WebAppl
{
    public class SearchModel : PageModel
    {
        public MyBdClient myBdClient = new MyBdClient();
        public List<Media> mediaResultByTag = new List<Media>();
        public List<Media> mediaResultByTagType = new List<Media>();
        public List<Media> mediaResultByName = new List<Media>();
        public async Task OnGetAsync()
        {
            string stringPrimit = Request.Query["search"];
            var mediaAll = await myBdClient.GetAllMediaAsync();

            if ((stringPrimit != null) && (stringPrimit != ""))
            {
                foreach(var item in mediaAll)
                {
                    if (item.Media_name==stringPrimit)
                    {
                        mediaResultByName.Add(item);
                    }
                    foreach(var element in item.TableWays)
                    {
                        if(element.Tag.Value_tag == stringPrimit)
                        {
                            mediaResultByTag.Add(item);
                        }
                        if (element.TagType.Value_tagType == stringPrimit)
                        {
                            mediaResultByTagType.Add(item);
                        }
                    }
                    
                }
            }
        }
    }
}