using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FootballClubApp.BLL.Entities;
using FootballClubApp.Services.Interfaces;
using FootballClubApp.ViewModels;
using FootballClubApp.ViewModels.LeaguesViewModels.Base;
using Microsoft.AspNetCore.Mvc;

namespace FootballClubApp.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILeaguesService _leagueServices;
        private readonly ISeasonsService _seasons;
        private readonly IMapper _mapper;

        public AdminController(ILeaguesService leagueServices, ISeasonsService seasons, IMapper mapper)
        {
            _leagueServices = leagueServices;
            _seasons = seasons;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var seasons = _seasons.GetSeasons();
            var model = _mapper.Map<List<Seasons>, List<SeasonsViewModel>>(seasons);

            return View(model);
        }

        public IActionResult GetCountryLeagues(int seasonId)
        {
            var model = _mapper.Map<List<CountryLeague>,List<CountryLeagueBaseModel>>(_leagueServices.GetLeagueRecords<CountryLeague>(seasonId));

            if(model.Count == 0)
            {
                return RedirectToAction("AddCountryLeague", new { seasonId = seasonId });
            }

            return View(model);
        }

        public IActionResult GetEuropeLeagues(int seasonId)
        {
            var model = _mapper.Map<List<EuropeLeague>, List<EuropeLeaguesBaseModel>>(_leagueServices.GetLeagueRecords<EuropeLeague>(seasonId));

            if (model.Count == 0)
            {
                return RedirectToAction("AddEuropeLeague", new { seasonId = seasonId });
            }

            return View(model);
        }

        public IActionResult GetEuropeEliminations(int seasonId)
        {
            var model = _mapper.Map<List<EuropeEliminations>, List<EliminationBaseModel>>(_leagueServices.GetEliminations(seasonId));
            if (model.Count == 0)
            {
                return RedirectToAction("AddElimination", new { seasonId = seasonId });
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult AddCountryLeague(int seasonId)
        {
            return View(seasonId);
        }

        [HttpPost]
        public IActionResult AddCountryLeague(int seasonId, CountryLeagueBaseModel obj)
        {
            if (obj != null)
            {
                var model = new CountryLeague()
                {
                    ClubName = obj.ClubName,
                    Draws = obj.Draws,
                    Loses = obj.Loses,
                    MatchesAmount = obj.MatchesAmount,
                    Place = obj.Place,
                    Points = obj.Points,
                    Wins = obj.Wins
                };
                _leagueServices.AddLeagueRecord<CountryLeague>(seasonId, model);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddEuropeLeague(int seasonId)
        {
            return View(seasonId);
        }

        [HttpPost]
        public IActionResult AddEuropeLeague(int seasonId, EuropeLeaguesBaseModel obj)
        {
            if (obj != null)
            {
                var model = new EuropeLeague()
                {
                    ClubName = obj.ClubName,
                    Draws = obj.Draws,
                    Loses = obj.Loses,
                    MatchesAmount = obj.MatchesAmount,
                    Place = obj.Place,
                    Points = obj.Points,
                    Wins = obj.Wins
                };
                _leagueServices.AddLeagueRecord<EuropeLeague>(seasonId, model);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddElimination(int seasonId)
        {
            return View(seasonId);
        }

        [HttpPost]
        public IActionResult AddElimination(int seasonId, EliminationBaseModel obj)
        {
            if (obj != null)
            {
                var model = new EuropeEliminations()
                {
                    AwayResult = obj.AwayResult,
                    HomeResult = obj.HomeResult,
                    NameOfCompetition = obj.NameOfCompetition,
                    NameOfStage = obj.NameOfStage,
                    Round = obj.Round,
                    SeasonId = seasonId,
                    Team = obj.Team
            };
                _leagueServices.AddEliminations(seasonId, model);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditCountryLeague(int seasonId,int id)
        {
            var model = _leagueServices.GetLeagueRecord<CountryLeague>(seasonId, id); 
            return View(model);
        }

        [HttpPost]
        public IActionResult EditCountryLeague(int seasonId, CountryLeagueBaseModel obj, int id)
        {
            if (obj != null)
            {
                var model = new CountryLeague()
                {
                    ClubName = obj.ClubName,
                    Draws = obj.Draws,
                    Loses = obj.Loses,
                    MatchesAmount = obj.MatchesAmount,
                    Place = obj.Place,
                    Points = obj.Points,
                    Wins = obj.Wins
                };
                _leagueServices.EditCountryLeagueRecord(seasonId,id, model);
            }
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCountryLeague(int seasonId, int id)
        {
            var model = _leagueServices.GetLeagueRecord<CountryLeague>(seasonId, id);

            _leagueServices.DeleteLeagueRecord<CountryLeague>(seasonId, id);
            return RedirectToAction("Index"); 
        }

        [HttpGet]
        public IActionResult EditEuropeLeague(int seasonId, int id)
        {
            var model = _leagueServices.GetLeagueRecord<EuropeLeague>(seasonId, id);
            return View(model);
        }

        [HttpPost]
        public IActionResult EditEuropeLeague(int seasonId, EuropeLeaguesBaseModel obj, int id)
        {
            if (obj != null)
            {
                var model = new EuropeLeague()
                {
                    ClubName = obj.ClubName,
                    Draws = obj.Draws,
                    Loses = obj.Loses,
                    MatchesAmount = obj.MatchesAmount,
                    Place = obj.Place,
                    Points = obj.Points,
                    Wins = obj.Wins,
                    NameOfCompetition = obj.NameOfCompetition
                };
                _leagueServices.EditEuropeLeagueRecord(seasonId, id, model);
            }
            return RedirectToAction("Index");
        }

        public IActionResult DeleteEuropeLeague(int seasonId, int id)
        {
            var model = _leagueServices.GetLeagueRecord<EuropeLeague>(seasonId, id);

            _leagueServices.DeleteLeagueRecord<EuropeLeague>(seasonId, id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditElimination(int seasonId, int id)
        {
            var model = _leagueServices.GetElimination(seasonId, id);
            return View(model);
        }

        [HttpPost]
        public IActionResult EditElimination(int seasonId, EliminationBaseModel obj, int id)
        {
            if (obj != null)
            {
                var model = new EuropeEliminations()
                {
                    AwayResult = obj.AwayResult,
                    HomeResult = obj.HomeResult,
                    NameOfCompetition = obj.NameOfCompetition,
                    NameOfStage = obj.NameOfStage,
                    Round = obj.Round,
                    SeasonId = seasonId,
                    Team = obj.Team
                };
                _leagueServices.EditEliminations(seasonId,id, model);
            }
            return RedirectToAction("Index");
        }

        public IActionResult DeleteElimination(int seasonId, int id)
        {
            var model = _leagueServices.GetElimination(seasonId, id);

            _leagueServices.DeleteLeagueRecord<EuropeLeague>(seasonId, id);
            return RedirectToAction("Index");
        }

    }
}