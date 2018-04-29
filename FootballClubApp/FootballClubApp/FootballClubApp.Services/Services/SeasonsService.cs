using System;
using System.Collections.Generic;
using System.Text;
using FootballClubApp.BLL.Entities;
using FootballClubApp.Services.Interfaces;
using FootballClubApp.DAL.EF;
using System.Linq;

namespace FootballClubApp.Services.Services
{
    public class SeasonsService : ISeasonsService
    {
        private ApplicationDbContext<User, Role, int> _ctx;

        public SeasonsService(ApplicationDbContext<User, Role, int> ctx)
        {
            _ctx = ctx;
        }

        public bool AddSeason(Seasons season)
        {
            try
            {
                _ctx.Seasons.Add(season);
                _ctx.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool DeleteSeason(int seasonId)
        {
            try
            {
                var season = _ctx.Seasons.Single(x => x.Id == seasonId);
                _ctx.Seasons.Remove(season);
                _ctx.SaveChanges();

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public Seasons GetSeason(int seasonId)
        {
            try
            {
                return _ctx.Seasons.Single(x => x.Id == seasonId);
            }
            catch(Exception)
            {
                return new Seasons();
            }
        }

        public List<Seasons> GetSeasons()
        {
            try
            {
                return _ctx.Seasons.ToList();
            }
            catch(Exception)
            {
                return new List<Seasons>();
            }
        }
    }
}
