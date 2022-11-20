using MyProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interfaces
{
    public interface IClaimService
    {
        List<ClaimDTO> GetList();

        ClaimDTO GetById(int id);

        public ClaimDTO Add(int id, int roleId, int perId);
 
        public void Delete(int id);

        public ClaimDTO Update(int id, int roleId, int perId);

    }
}
