using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FootballClubApp.Services.Interfaces;
using FootballClubApp.BLL.Entities;

namespace FootballClubApp.Web.Controllers
{
    public class BasicInformationController : Controller
    {
        private readonly ISeasonsService _seasonService;
        private readonly IBasicInformationService _basicInformationsService;

        public BasicInformationController(ISeasonsService seasonService, IBasicInformationService basicInformationsService)
        {
            this._seasonService = seasonService;
            this._basicInformationsService = basicInformationsService;
        }

        public IActionResult Index()
        {
            var model = _basicInformationsService.GetBasicInformations();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddBasicInformation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBasicInformation(BasicInformations info)
        {
            if(_basicInformationsService.AddBasicInformation(info))
            return RedirectToAction("Index");
            
            return View();
        }

        [HttpGet]
        public IActionResult EditBasicInformation(int id)
        {
            var model = _basicInformationsService.GetBasicInfotrmation(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult EditBasicInformation(int id, BasicInformations info)
        {
            if (_basicInformationsService.EditBasicInformation(id, info))
            {
                return RedirectToAction("Index");
            }
            else
            {
                var model = _basicInformationsService.GetBasicInfotrmation(id);
                return View(model);
            }
        }

        public IActionResult DeleteBasicInformation(int id)
        {
            if(_basicInformationsService.DeleteBasicInformation(id))
            return RedirectToAction("Index");

            return null;
        }
    }
}