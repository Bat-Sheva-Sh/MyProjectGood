using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTOs;
using MyProject.Mock;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;
using MyProject.Services.Interfaces;
using MyProject.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MyProject.WebApi_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]
        public List<RoleDTO> Get()
        //Role
        {
            return _roleService.GetList();
        }

        [HttpGet("{id}")]
        public RoleDTO Get(int id)
        {
            return _roleService.GetById(id);
        }

        [HttpPost]
        public void Post(Role r)//insert-add
        {
            _roleService.Add(r.Id, r.Name, r.Description);
        }

        [HttpPut]
        public IEnumerable<RoleDTO> Put(int id, string name, string description)//update
        {
            _roleService.Update(id, name, description);
            return _roleService.GetList();
        }

        [HttpDelete("{id}")]
        public IEnumerable<RoleDTO> Delete(int id)
        {
            _roleService.Delete(id);
            return _roleService.GetList();
        }
        //List<Role>

    }
}

