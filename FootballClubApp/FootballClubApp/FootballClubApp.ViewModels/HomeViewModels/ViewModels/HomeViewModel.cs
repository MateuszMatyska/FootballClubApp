using FootballClubApp.ViewModels.HomeViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballClubApp.ViewModels.HomeViewModels.ViewModels
{
    public class HomeViewModel
    {
        public List<BasicInformationsModel> BasicInformations { get; set; }
        public List<LeagueModel> Leagues { get; set; }
        public CoachesModel Coach { get; set; }
    }
}
