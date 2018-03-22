using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using FootballClub.DAL.Models;

namespace FootballClub.DAL
{
    public class FootballClubDB : DbContext
    {
        public FootballClubDB(DbContextOptions<FootballClubDB> options) : base(options) { }

        public DbSet<BasicInformations> BasicInformations { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
