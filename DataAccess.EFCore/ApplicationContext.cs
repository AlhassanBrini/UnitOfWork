using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.EFCore
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Developer>().HasData(
                new Developer()
                {
                    Id = 1,
                    Name = "AlHassan Brini",
                    Followers = 10

                },

                new Developer()
                {
                    Id = 2,
                    Name = "Bochra Bouazizi",
                    Followers = 5
                });

            modelBuilder.Entity<Project>().HasData(
                new Project()
                {
                    Id = 1,
                    Name = "EasyDoctor",
                    DeveloperId = 1
                },
                
                new Project()
                {
                    Id = 2,
                    Name = "SchoolManagementERP",
                    DeveloperId = 1
                });

        }
    }
}
