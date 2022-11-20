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
    public class ClaimService : IClaimService
    {
        private readonly IClaimRepository _claimRepository;
        private readonly IMapper _mapper;
        public ClaimService(IClaimRepository cliamRepository, IMapper mapper)
        {
            _claimRepository = cliamRepository;
            _mapper = mapper;
        }

        public ClaimDTO Add(int id, int roleId, int perId)
        {
            //לוגיקה עסקית חסרה
            var newClaim = new ClaimDTO { Id = id, RoleId = roleId, PerId = perId };
            _claimRepository.Add(newClaim.Id, newClaim.RoleId, newClaim.PerId);
            return newClaim;
        }

        public ClaimDTO Update(int id, int roleId, int perId)
        {
            //לוגיקה עסקית חסרה
            ClaimDTO newClaim = GetById(id);
            newClaim.RoleId = roleId;
            newClaim.PerId = perId;
            return newClaim;
        }

        public void Delete(int id)
        {
            for (int i = 0; i < _claimRepository.GetAll().Count; i++)
            {
                if (_claimRepository.GetAll()[i].Id == id)
                {
                    _claimRepository.GetAll().RemoveAt(i);
                    break;
                }
            }
        }

        public ClaimDTO GetById(int id)
        {
            //לוגיקה עסקית
            var claim = _claimRepository.GetById(id);
            return _mapper.Map<ClaimDTO>(claim);
        }

        public List<ClaimDTO> GetList()
        {
            return _mapper.Map<List<ClaimDTO>>(_claimRepository.GetAll());
        }

    }
}
