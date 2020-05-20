using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppl.Models
{
    public class TableWays
    {
        public int Id { get; set; }
        public bool Is_Deleted { get; set; }

        public virtual Media Medium { get; set; }
        public virtual Tags Tag { get; set; }
        public virtual TagType TagType { get; set; }
    }
}
