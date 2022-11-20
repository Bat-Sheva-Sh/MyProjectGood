using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Entities
{
    //something missing down with the enum
    public enum Policy { Deny, Allow }
    public class Claim
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int PerId { get; set; }

        public override string ToString()
        {
            return $"id: {Id}, roleId: {RoleId}, perid: {PerId}";
        }

        //public int Policy { get; set; }
    }
}
