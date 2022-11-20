using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Interfaces
{
    public interface IRoleRepository
    {
        List<Role> GetAll();
        Role GetById(int id);
        Role Add(int id, string name, string description);
        Role Update(int id, string name, string description);
        void Delete(int id);
    }
}
