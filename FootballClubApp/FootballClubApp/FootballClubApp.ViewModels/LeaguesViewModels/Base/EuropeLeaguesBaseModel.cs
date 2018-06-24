using System;
using System.Collections.Generic;
using System.Text;

namespace FootballClubApp.ViewModels.LeaguesViewModels.Base
{
    public class EuropeLeaguesBaseModel
    {
        public int Id { get; set; }
        public int Place { get; set; }
        public string ClubName { get; set; }
        public int MatchesAmount { get; set; }
        public int Points { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Loses { get; set; }
        public string NameOfCompetition { get; set; }
        public int SeasonId { get; set; }
    }
}
