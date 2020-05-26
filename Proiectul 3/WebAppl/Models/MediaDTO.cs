using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppl.Models
{
    public class MediaDTO
    {
        public MediaDTO()
        {
            this.Is_Deleted = false;
            this.TableWaysDTO = new HashSet<TableWaysDTO>();
        }

        public int Id_Media { get; set; }
        public string Media_name { get; set; }
        public string Media_path { get; set; }
        public bool Is_Deleted { get; set; }

        public virtual ICollection<TableWaysDTO> TableWaysDTO { get; set; }

    }
}
