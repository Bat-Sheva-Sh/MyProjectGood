using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;
        
        //ctor
        public RoleService(IRoleRepository roleRepository, IMapper mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }

        public RoleDTO Add(int id, string name, string title)
        {
            //לוגיקה עסקית חסרה
            var newRole = new RoleDTO { Id = id, Name = name, Title = title };
            _roleRepository.Add(newRole.Id, newRole.Name, newRole.Title);/////map- convert
            return newRole;
        }

        public RoleDTO Update(int id, string name, string title)
        {
            //לוגיקה עסקית חסרה
            RoleDTO newRole = GetById(id);
            newRole.Name = name;
            newRole.Title = title;
            return newRole;
        }

        public void Delete(int id)
        {
            for (int i = 0; i < _roleRepository.GetAll().Count; i++)
            {
                if (_roleRepository.GetAll()[i].Id == id)
                {
                    _roleRepository.GetAll().RemoveAt(i);
                    break;
                }
            }
        }

        public RoleDTO GetById(int id)
        {
            //לוגיקה עסקית
           var role = _roleRepository.GetById(id);
            return _mapper.Map<RoleDTO>(role);
        }

        public List<RoleDTO> GetList()
        {
            return _mapper.Map <List<RoleDTO>>(_roleRepository.GetAll());
        }

    }
}
