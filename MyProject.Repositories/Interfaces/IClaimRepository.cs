using System;
using System.Collections.Generic;
using System.Text;
using MyProject.Repositories.Entities;

namespace MyProject.Repositories.Interfaces
{
    public interface IClaimRepository
    {
        List<Claim> GetAll();
        Claim GetById(int id);
        Claim Add(int id, int roleId, int perId);//how to get the enum
        Claim Update(int id, int roleId, int perId);//how to get the enum
        void Delete(int id);
    }
}
