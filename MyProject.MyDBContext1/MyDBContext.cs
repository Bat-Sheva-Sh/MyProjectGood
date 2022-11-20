using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using System;

namespace MyProject.MyDBContext1
{
    public class MyDBContext:DbContext
    {
        private const string ConnectionString = "Connectionstring";

        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyProjectDb;Trusted_Connection=True;");////?????maybe a nevigate
        }

    }
}
