using MyProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IRoleService
    {
        public RoleDTO Add(int id, string name, string description);

        public void Delete(int id);

        public RoleDTO Update(int id, string name, string description);

        List<RoleDTO> GetList();

        RoleDTO GetById(int id);

        //add
        //update
        //delete

        //search
    }
}
