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
  
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository _permissionRepository;
        private readonly IMapper _mapper;
        public PermissionService(IPermissionRepository permissionRepository, IMapper mapper)
        {
            _permissionRepository = permissionRepository;
            _mapper = mapper;
        }

        public PermissionDTO Add(int id, string name, string description)
        {
            //לוגיקה עסקית חסרה
            var newPer = new PermissionDTO { Id = id, Name = name, Description = description };
            _permissionRepository.Add(newPer.Id, newPer.Name, newPer.Description);
            return newPer;
        }

        public PermissionDTO Update(int id, string name, string description)
        {
            //לוגיקה עסקית חסרה
            PermissionDTO newPer = GetById(id);
            newPer.Name = name;
            newPer.Description = description;
            return newPer;
        }

        public void Delete(int id)
        {
            for (int i = 0; i < _permissionRepository.GetAll().Count; i++)
            {
                if (_permissionRepository.GetAll()[i].Id == id)
                {
                    _permissionRepository.GetAll().RemoveAt(i);
                    break;
                }
            }
        }

        public PermissionDTO GetById(int id)
        {
            //לוגיקה עסקית
            var permission =_permissionRepository.GetById(id);
            return _mapper.Map<PermissionDTO>(permission);
        }

        public List<PermissionDTO> GetList()
        {
            return _mapper.Map<List<PermissionDTO>>(_permissionRepository.GetAll());
        }

    }
}
