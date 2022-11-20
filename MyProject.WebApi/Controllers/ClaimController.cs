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
    public class ClaimController : ControllerBase
    {
        private readonly IClaimRepository _claimRepository;

        public ClaimController(IClaimRepository claimRepository)
        {
            _claimRepository = claimRepository;
        }

        [HttpGet]
        public List<Claim> Get()
        {
            return _claimRepository.GetAll();
        }

        [HttpGet ("{id}")]
        public Claim Get(int id)
        {
            return _claimRepository.GetById(id);
        }

        [HttpPost]
        public void Post(Claim c)//update
        {
            _claimRepository.Add(c.Id, c.RoleId, c.PerId);
        }

        [HttpPut]
        public void Put(Claim c)//insert-add
        {
            _claimRepository.Update(c.Id, c.RoleId, c.PerId);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _claimRepository.Delete(id);
        }


    }
}
