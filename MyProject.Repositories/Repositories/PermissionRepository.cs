using System;
using System.Collections.Generic;
using System.Text;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;

namespace MyProject.Repositories.Repositories
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly IContext _context;
        public PermissionRepository(IContext context)
        {
            _context = context;
        }
        public Permission Add(int id, string name, string description)
        {
            var newPer = new Permission { Id = id, Name = name, Description = description };
            _context.Permissions.Add(newPer);
            return newPer;
        }
        public void Delete(int id)
        {
            for (int i = 0; i < _context.Permissions.Count; i++)
            {
                if (_context.Permissions[i].Id == id)
                {
                    _context.Permissions.RemoveAt(i);
                    break;
                }
            }
        }

        public List<Permission> GetAll()
        {
            return _context.Permissions;
        }

        public Permission GetById(int id)
        {
            for (int i = 0; i < _context.Permissions.Count; i++)
            {
                if (_context.Permissions[i].Id == id)
                {
                    return _context.Permissions[i];
                }
            }
            return _context.Permissions[0];
        }

        //הסתמכתי על כך שבעדכון חיב משהו אחד קים וזה  ה- איידי
        public Permission Update(int id, string name, string description)
        {
            Permission newPer = GetById(id);

            newPer.Name = name;
            newPer.Description = description;

            return newPer;
        }
    }
}
