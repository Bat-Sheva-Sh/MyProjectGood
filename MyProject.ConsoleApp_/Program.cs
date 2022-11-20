using System;
using MyProject.Mock;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Repositories;

namespace MyProject.ConsoleApp_
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new MockContext();

            context.Roles.ForEach((role) =>
            {
                Console.WriteLine(role.ToString());
            });

            context.Permissions.ForEach((per) =>
            {
                Console.WriteLine(per.ToString());
            });

            context.Claims.ForEach((claim) =>
            {
                Console.WriteLine(claim.ToString());
            });

            Console.WriteLine("=======");

            RoleRepository roleRepository = new RoleRepository(context);
            roleRepository.Add(3, "super user", "great");

            ClaimRepository claimRepository = new ClaimRepository(context);
            claimRepository.Add(3, 30, 300);

            PermissionRepository permissionRepository = new PermissionRepository(context);
            permissionRepository.Add(3, "super- user", "SEE ALL");

            context.Roles.ForEach((role) =>
            {
                Console.WriteLine(role.ToString());
            });

            context.Permissions.ForEach((per) =>
            {
                Console.WriteLine(per.ToString());
            });

            context.Claims.ForEach((claim) =>
            {
                Console.WriteLine(claim.ToString());
            });
        }
    }
}
