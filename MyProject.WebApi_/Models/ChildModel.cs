//using MyProject.Repositories.Entities;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.WebApi_.Models
{
    public class ChildModel
    {
        //public int Id { get; set; }
        public string ChildId { get; set; }//tz
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        [ForeignKey("Parent")]
        public int ParentId { get; set; }
        public UserModel Parent { get; set; }
    }
}
