using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppl.Models
{
    public class TagsDTO
    {
        public TagsDTO()
        {
            this.TableWaysDTO = new HashSet<TableWaysDTO>();
        }

        public int Id_Tags { get; set; }
        public string Value_tag { get; set; }
        public bool Is_Deleted { get; set; }

        public virtual ICollection<TableWaysDTO> TableWaysDTO { get; set; }
    }
}
