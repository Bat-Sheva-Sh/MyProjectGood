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
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        ///IRoleRepository _roleRepository

        public RoleController(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        [HttpGet]
        public List<RoleDTO> Get()
            //Role
        {
            return _roleRepository.GetAll();
        }

        [HttpGet ("{id}")]
        public Role Get(int id)
        {
            return _roleRepository.GetById(id);
        }

        [HttpPost]
        public void Post(Role r)//insert-add
        {
            _roleRepository.Add(r.Id, r.Name, r.Description);
        }

        [HttpPut]
        public IEnumerable<Role> Put(int id, string name, string description)//update
        {
            _roleRepository.Update(id, name, description);
            return _roleRepository.GetAll();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Role> Delete(int id)
        {
            _roleRepository.Delete(id);
            return _roleRepository.GetAll();
        }
        //List<Role>

    }
}
