using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppl.Models
{
    public class Media
    {
        public Media()
        {
            this.Is_Deleted = false;
            this.TableWays = new HashSet<TableWays>();
        }

        public int Id_Media { get; set; }
        public string Media_name { get; set; }
        public string Media_path { get; set; }
        public bool Is_Deleted { get; set; }

        public virtual ICollection<TableWays> TableWays { get; set; }

    }
}
