using FootballClubApp.BLL.Entities;
using FootballClubApp.DAL.EF;
using FootballClubApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballClubApp.Services.Services
{
    public class LeagueServices : ILeaguesService
    {
        private readonly ApplicationDbContext<User, Role, int> _ctx;

        public LeagueServices(ApplicationDbContext<User, Role, int> ctx)
        {
            _ctx = ctx;
        }

        public bool AddLeagueRecord<T>(int seasonId, T record) where T : League
        {
            try
            {
                record.SeasonId = seasonId;
                _ctx.Set<T>().Add(record);
                _ctx.SaveChanges();

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool DeleteLeagueRecord<T>(int seasonId, int recordId) where T : League
        {
            try
            {
                var item = _ctx.Set<T>().Single(x => x.Id == recordId && x.SeasonId == seasonId);
                _ctx.Set<T>().Remove(item);
                _ctx.SaveChanges();

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool EditCountryLeagueRecord(int seasonId, int recordId, CountryLeague record)
        {
            try
            {
                var oldItem = _ctx.CountryLeague.Single(x => x.Id == recordId && x.SeasonId == seasonId);

                oldItem.ClubName = record.ClubName;
                oldItem.Draws = record.Draws;
                oldItem.Loses = record.Loses;
                oldItem.MatchesAmount = record.MatchesAmount;
                oldItem.Place = record.Place;
                oldItem.Points = record.Points;
                oldItem.Wins = record.Wins;

                _ctx.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditEuropeLeagueRecord(int seasonId, int recordId, EuropeLeague record)
        {
            try
            {
                var oldItem = _ctx.EuropeLeague.Single(x => x.Id == recordId && x.SeasonId == seasonId);

                oldItem.ClubName = record.ClubName;
                oldItem.Draws = record.Draws;
                oldItem.Loses = record.Loses;
                oldItem.MatchesAmount = record.MatchesAmount;
                oldItem.Place = record.Place;
                oldItem.Points = record.Points;
                oldItem.Wins = record.Wins;
                oldItem.NameOfCompetition = record.NameOfCompetition;

                _ctx.SaveChanges();

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public T GetLeagueRecord<T>(int seasonId, int recordId) where T : League
        {
            try
            {
                return _ctx.Set<T>().Single(x => x.Id == recordId && x.SeasonId == seasonId);
            }
            catch(Exception)
            {
                throw;
            }
        }

        public List<T> GetLeagueRecords<T>(int seasonId) where T : League
        {
            try
            {
                return _ctx.Set<T>().Where(x => x.SeasonId == seasonId).ToList();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public List<EuropeEliminations> GetEliminations(int seasonId)
        {
            try
            {
                return _ctx.EuropeEliminations.Where(x => x.SeasonId == seasonId).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool AddEliminations(int seasonId, EuropeEliminations elimination)
        {
            try
            {
                elimination.SeasonId = seasonId;
                _ctx.EuropeEliminations.Add(elimination);
                _ctx.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditEliminations(int seasonId, int eliminationId, EuropeEliminations elimination)
        {
            try
            {
                var oldItem = _ctx.EuropeEliminations.First(x => x.SeasonId == seasonId && x.Id == eliminationId);

                oldItem.AwayResult = elimination.AwayResult;
                oldItem.HomeResult = elimination.HomeResult;
                oldItem.NameOfCompetition = elimination.NameOfCompetition;
                oldItem.NameOfStage = elimination.NameOfStage;
                oldItem.Round = elimination.Round;
                oldItem.SeasonId = elimination.SeasonId;
                oldItem.Team = elimination.Team;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteEliminations(int seasonId, int eliminationId)
        {
            try
            {
                var item = _ctx.EuropeEliminations.First(x => x.SeasonId == seasonId && x.Id == eliminationId);
                _ctx.EuropeEliminations.Remove(item);
                _ctx.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
