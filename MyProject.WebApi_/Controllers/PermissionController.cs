using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTOs;
using MyProject.Mock;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using MyProject.Services.Services;
//using MyProject.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WebApi_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionService _permissionService;

        public PermissionController(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        [HttpGet]
        public List<PermissionDTO> Get()
        {
            return _permissionService.GetList();
        }

        [HttpGet("{id}")]
        public PermissionDTO Get(int id)
        {
            return _permissionService.GetById(id);
        }

        [HttpPost]
        public void Post(Permission p)//update
        {
            _permissionService.Add(p.Id, p.Name, p.Description);
        }

        [HttpPut]
        public void Put(Permission p)//insert-add
        {
            _permissionService.Update(p.Id, p.Name, p.Description);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _permissionService.Delete(id);
        }


    }
}
