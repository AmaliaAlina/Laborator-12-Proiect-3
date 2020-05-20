using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppl.Models
{
    public class Tags
    {
        public Tags()
        {
            this.TableWays = new HashSet<TableWays>();
        }

        public int Id_Tags { get; set; }
        public string Value_tag { get; set; }
        public bool Is_Deleted { get; set; }

        public virtual ICollection<TableWays> TableWays { get; set; }
    }
}
