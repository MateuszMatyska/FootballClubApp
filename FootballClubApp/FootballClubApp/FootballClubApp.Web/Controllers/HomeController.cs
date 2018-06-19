using DataAccessLayer.Core.Interfaces.UoW;
using FootballClubApp.BLL.Entities;
using FootballClubApp.Services.Interfaces;
using FootballClubApp.ViewModels.HomeViewModels.Base;
using FootballClubApp.ViewModels.HomeViewModels.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace FootballClubApp.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ISeasonsService _seasonService;
        private readonly IBasicInformationService _basicInformationsService;
        private readonly ILeaguesService _leaguesService;

        public HomeController(ILeaguesService leaguesService, ISeasonsService seasons, IBasicInformationService basicInformation, IUnitOfWork uow, ILoggerFactory loggerFactory) : base(uow, loggerFactory)
        {
            _seasonService = seasons;
            _basicInformationsService = basicInformation;
            _leaguesService = leaguesService;
        }

        public IActionResult Index()
        {
            var model = new HomeViewModel();
            model.BasicInformations = AutoMapper.Mapper.Map<List<BasicInformations>,List<BasicInformationsModel>>(_basicInformationsService.GetBasicInformations());
            model.Leagues = AutoMapper.Mapper.Map<List<CountryLeague>, List<LeagueModel>>(_leaguesService.GetLeagueRecords<CountryLeague>(1));

            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
    }
}
