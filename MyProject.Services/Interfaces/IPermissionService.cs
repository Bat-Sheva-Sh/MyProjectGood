using MyProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IPermissionService
    {
        public PermissionDTO Add(int id, string name, string description);

        public void Delete(int id);

        public PermissionDTO Update(int id, string name, string description);

        List<PermissionDTO> GetList();

        PermissionDTO GetById(int id);
    }
}
