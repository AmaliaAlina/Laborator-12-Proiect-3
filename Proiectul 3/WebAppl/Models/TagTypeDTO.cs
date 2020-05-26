using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppl.Models
{
    public class TagTypeDTO
    {

        public TagTypeDTO()
        {
            this.Is_Deleted = false;
            this.TableWaysDTO = new HashSet<TableWaysDTO>();
        }

        public int Id_TagType { get; set; }
        public string Value_tagType { get; set; }
        public bool Is_Deleted { get; set; }

        public virtual ICollection<TableWaysDTO> TableWaysDTO { get; set; }
    }
}
