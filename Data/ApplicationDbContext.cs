using System;
using System.Collections.Generic;
using System.Text;
using HospitalsBlz.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HospitalsBlz.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Hospitals> Hospitals { get; set; }
        public DbSet<DepartmentsHistory> DepartmentsHistory { get; set; }
        public DbSet<Positions> Positions { get; set; }
        public DbSet<Emp> Emp { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCount> ProductCounts { get; set; }
        public DbSet<ProductCountHistory> ProductCountHistory { get; set; }
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        //    : base(options)
        //{
        //}
         
    }

}
