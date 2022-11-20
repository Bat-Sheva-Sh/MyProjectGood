using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Common.DTOs
{
    //i didn't do enums
    public class ClaimDTO
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int PerId { get; set; }
    }
}
