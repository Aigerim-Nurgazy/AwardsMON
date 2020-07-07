using System;
using System.Collections.Generic;
using System.Text;
using BlzMON.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlzMON.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Initializers> Initializers { get; set; }
        public DbSet<Regions> Region { get; set; }
         public DbSet<Areass> Areaq { get; set; }
        public DbSet<Possitions> Possition { get; set; }
        public DbSet<Educations> Education { get; set; }
        public DbSet<Departaments> Departaments { get; set; }
        public DbSet<SecondDeps> SecondDep { get; set; }
        public DbSet<Commissions> Commission { get; set; }
        public DbSet<Awards> Award { get; set; }
        public DbSet<Documents> Document { get; set; }
        //public DbSet<Orders> Order { get; set; }
        public DbSet<Orders> Order { get; set; }

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
