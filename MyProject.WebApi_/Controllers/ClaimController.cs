using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTOs;
using MyProject.Mock;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.WebApi_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController : ControllerBase
    {
        private readonly IClaimService _claimService;

        public ClaimController(IClaimService claimService)
        {
            _claimService = claimService;
        }

        [HttpGet]
        public List<ClaimDTO> Get()
        {
            return _claimService.GetList();
        }

        [HttpGet("{id}")]
        public ClaimDTO Get(int id)
        {
            return _claimService.GetById(id);
        }

        [HttpPost]
        public void Post(Claim c)//update
        {
            _claimService.Add(c.Id, c.RoleId, c.PerId);
        }

        [HttpPut]
        public void Put(Claim c)//insert-add
        {
            _claimService.Update(c.Id, c.RoleId, c.PerId);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _claimService.Delete(id);
        }


    }
}

