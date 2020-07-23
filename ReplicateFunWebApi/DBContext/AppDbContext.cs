﻿using FunApp.Common.Models;
using Microsoft.EntityFrameworkCore;

namespace FunApp.WebApI.DBContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<TeamMember> TeamMembers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<TeamMember>().HasData(new TeamMember { Id = 1, Name = "Ashish" });
        }
    }
}