using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppl.Models
{
    public class TableWaysDTO
    {
        public int Id { get; set; }
        public bool Is_Deleted { get; set; }

        public virtual MediaDTO Medium { get; set; }
        public virtual TagsDTO Tag { get; set; }
        public virtual TagTypeDTO TagType { get; set; }
    }
}
