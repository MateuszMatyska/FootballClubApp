using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FootballClubApp.BLL.Entities;

namespace FootballClubApp.DAL.EF
{
    public class ApplicationDbContext<TUser, TRole, TKey> : IdentityDbContext<TUser, TRole, TKey>
        where TUser : IdentityUser<TKey>
        where TRole : IdentityRole<TKey>
        where TKey : IEquatable<TKey>
    {
        private readonly ConnectionStringDto _connectionStringDto;

        // Table properties e.g
        // public virtual DbSet<Entity> TableName { get; set; }
        public virtual DbSet<BasicInformations> BasicInformations { get; set; }
        public virtual DbSet<Seasons> Seasons { get; set; }
        public virtual DbSet<Coaches> Coaches { get; set; }
        public virtual DbSet<EuropeEliminations> EuropeEliminations { get; set; }
        public virtual DbSet<EuropeLeague> EuropeLeague { get; set; }
        public virtual DbSet<CountryLeague> CountryLeague { get; set; }


        public ApplicationDbContext(ConnectionStringDto connectionStringDto)
        {
            _connectionStringDto = connectionStringDto;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_connectionStringDto.ConnectionString); // for provider SQL Server 
            // optionsBuilder.UseMySql(_connectionStringDto.ConnectionString); //for provider My SQL 

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Fluent API commands
        }
    }

}