using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Mock;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionRepository _permissionRepository;

        public PermissionController(IPermissionRepository permissionRepository)
        {
            _permissionRepository = permissionRepository;
        }

        [HttpGet]
        public List<Permission> Get()
        {
            return _permissionRepository.GetAll();
        }

        [HttpGet ("{id}")]
        public Permission Get(int id)
        {
            return _permissionRepository.GetById(id);
        }

        [HttpPost]
        public void Post(Permission p)//update
        {
            _permissionRepository.Add(p.Id, p.Name, p.Description);
        }

        [HttpPut]
        public void Put(Permission p)//insert-add
        {
            _permissionRepository.Update(p.Id, p.Name, p.Description);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _permissionRepository.Delete(id);
        }


    }
}
