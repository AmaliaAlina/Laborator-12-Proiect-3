using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppl.Models
{
    public class TagType
    {

        public TagType()
        {
            this.Is_Deleted = false;
            this.TableWays = new HashSet<TableWays>();
        }

        public int Id_TagType { get; set; }
        public string Value_tagType { get; set; }
        public bool Is_Deleted { get; set; }

        public virtual ICollection<TableWays> TableWays { get; set; }
    }
}
