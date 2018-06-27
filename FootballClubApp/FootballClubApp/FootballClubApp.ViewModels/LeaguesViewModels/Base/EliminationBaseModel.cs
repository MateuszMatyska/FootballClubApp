using System;
using System.Collections.Generic;
using System.Text;

namespace FootballClubApp.ViewModels.LeaguesViewModels.Base
{
    public class EliminationBaseModel
    {
        public int Id { get; set; }
        public string Team { get; set; }
        public string HomeResult { get; set; }
        public string AwayResult { get; set; }
        public int Round { get; set; }
        public string NameOfStage { get; set; }
        public string NameOfCompetition { get; set; }

        public int SeasonId { get; set; }
    }
}
