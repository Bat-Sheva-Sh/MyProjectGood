using System;
using System.Collections.Generic;
using System.Text;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;

namespace MyProject.Repositories.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly IContext _context;
        public RoleRepository(IContext context)
        {
            _context = context;
        }
        public Role Add(int id, string name, string description)
        {
            var newRole = new Role { Id = id, Name = name, Description = description };
            _context.Roles.Add(newRole);
            return newRole;
        }
        public void Delete(int id)
        {
            for (int i = 0; i < _context.Roles.Count; i++)
            {
                if (_context.Roles[i].Id == id)
                {
                    _context.Roles.RemoveAt(i);
                    break;
                }
            }
        }

        public List<Role> GetAll()
        {
            return _context.Roles;
        }

        public Role GetById(int id)
        {
            for (int i = 0; i < _context.Roles.Count; i++)
            {
                if (_context.Roles[i].Id == id)
                {
                    return _context.Roles[i];
                }
            }
            return _context.Roles[0];
        }

        //הסתמכתי על כך שבעדכון חיב משהו אחד קים וזה  ה- איידי
        public Role Update(int id, string name, string description)
        {
            Role newRole = GetById(id);

            newRole.Name = name;
            newRole.Description = description;
            
            return newRole;
        }
    }
}
