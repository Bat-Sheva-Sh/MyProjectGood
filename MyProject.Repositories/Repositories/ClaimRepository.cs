using System;
using System.Collections.Generic;
using System.Text;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;

namespace MyProject.Repositories.Repositories
{
    public class ClaimRepository : IClaimRepository
    {
        private readonly IContext _context;
        public ClaimRepository(IContext context)
        {
            _context = context;
        }
        public Claim Add(int id, int roleId, int perId)
        {
            var newClaim = new Claim { Id = id, RoleId=roleId, PerId=perId};
            _context.Claims.Add(newClaim);
            return newClaim;
        }
        public void Delete(int id)
        {
            for (int i = 0; i < _context.Claims.Count; i++)
            {
                if (_context.Claims[i].Id == id)
                {
                    _context.Claims.RemoveAt(i);
                    break;
                }
            }
        }

        public List<Claim> GetAll()
        {
            return _context.Claims;
        }

        public Claim GetById(int id)
        {
            for (int i = 0; i < _context.Claims.Count; i++)
            {
                if (_context.Claims[i].Id == id)
                {
                    return _context.Claims[i];
                }
            }
            return _context.Claims[0];
        }

        //הסתמכתי על כך שבעדכון חיב משהו אחד קים וזה  ה- איידי
        public Claim Update(int id, int roleId, int perId)
        {
            Claim newClaim = GetById(id);

            newClaim.RoleId = roleId;
            newClaim.PerId = perId;

            return newClaim;
        }
    }
}
