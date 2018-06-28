using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FootballClubApp.ViewModels.LeaguesViewModels.Base
{
    public class EliminationBaseModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 40)]
        public string Team { get; set; }
        [Required]
        [StringLength(maximumLength: 2)]
        public string HomeResult { get; set; }
        [Required]
        [StringLength(maximumLength: 2)]
        public string AwayResult { get; set; }
        [Required]
        public int Round { get; set; }
        [Required]
        [StringLength(maximumLength: 40)]
        public string NameOfStage { get; set; }
        [Required]
        [StringLength(maximumLength: 40)]
        public string NameOfCompetition { get; set; }

        public int SeasonId { get; set; }
    }
}
