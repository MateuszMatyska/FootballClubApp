using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FootballClubApp.ViewModels.LeaguesViewModels.Base
{
    public class EuropeLeaguesBaseModel
    {
        public int Id { get; set; }
        [Required]
        public int Place { get; set; }
        [Required]
        [StringLength(maximumLength: 40)]
        public string ClubName { get; set; }
        [Required]
        public int MatchesAmount { get; set; }
        [Required]
        public int Points { get; set; }
        [Required]
        public int Wins { get; set; }
        [Required]
        public int Draws { get; set; }
        [Required]
        public int Loses { get; set; }
        [Required]
        [StringLength(maximumLength: 40)]
        public string NameOfCompetition { get; set; }
        public int SeasonId { get; set; }
    }
}
