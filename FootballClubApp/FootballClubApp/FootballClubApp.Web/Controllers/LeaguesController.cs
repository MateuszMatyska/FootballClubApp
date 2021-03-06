﻿using AutoMapper;
using FootballClubApp.BLL.Entities;
using FootballClubApp.Services.Interfaces;
using FootballClubApp.ViewModels;
using FootballClubApp.ViewModels.LeaguesViewModels.Base;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FootballClubApp.Web.Controllers
{
    public class LeaguesController : Controller
    {
        private readonly ILeaguesService _leagueServices;
        private readonly ISeasonsService _seasons;
        private readonly IMapper _mapper; 

        public LeaguesController(ILeaguesService leagueServices, ISeasonsService seasons, IMapper mapper)
        {
            _leagueServices = leagueServices;
            _seasons = seasons;
            _mapper = mapper;
        }

        public IActionResult CountryLeague()
        {
            var seasons = _seasons.GetSeasons();
            var model = _mapper.Map<List<Seasons>, List<SeasonsViewModel>>(seasons);
            
            return View(model);
        }

        public IActionResult EuropeLeague()
        {
            var seasons = _seasons.GetSeasons();
            var model = _mapper.Map<List<Seasons>, List<SeasonsViewModel>>(seasons);

            return View(model);
        }

        public IActionResult EuropeElimination()
        {
            var seasons = _seasons.GetSeasons();
            var model = _mapper.Map<List<Seasons>, List<SeasonsViewModel>>(seasons);

            return View(model);
        }

        public IActionResult GetCountryLeaguesResults(int seasonId)
        {
            var countryLeagueResult = _leagueServices.GetLeagueRecords<CountryLeague>(seasonId);
            var results = JsonConvert.SerializeObject(_mapper.Map<List<CountryLeague>, List<CountryLeagueBaseModel>>(countryLeagueResult));

            return Json(results);
        }

        public IActionResult GetEuropeLeaguesResults(int seasonId)
        {
            var europeLeagueResult = _leagueServices.GetLeagueRecords<EuropeLeague>(seasonId);
            var results = JsonConvert.SerializeObject(_mapper.Map<List<EuropeLeague>, List<EuropeLeaguesBaseModel>>(europeLeagueResult));

            return Json(results);
        }

        public IActionResult GetElimination(int seasonId)
        {
            var elimination = _leagueServices.GetEliminations(seasonId);
            var result = JsonConvert.SerializeObject(elimination);

            return Json(result);
        }
    }
}