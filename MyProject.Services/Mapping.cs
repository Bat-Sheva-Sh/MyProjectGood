using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            //role
            CreateMap<Role, RoleDTO>()
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Description))
                .ReverseMap();
            //claim
            CreateMap<Claim, ClaimDTO>().ReverseMap();
            //permission
            CreateMap<Permission, PermissionDTO>().ReverseMap();

        }
    }
}
