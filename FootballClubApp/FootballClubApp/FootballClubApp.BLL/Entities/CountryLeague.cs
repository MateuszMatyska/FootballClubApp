using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FootballClubApp.BLL.Entities
{
    public class CountryLeague:League
    {
        public int Place { get; set; }
        public string ClubName { get; set; }
        public int MatchesAmount { get; set; }
        public int Points { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Loses { get; set; }
    }
}
