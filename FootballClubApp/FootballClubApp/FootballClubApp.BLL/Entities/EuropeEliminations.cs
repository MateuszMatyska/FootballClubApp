using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FootballClubApp.BLL.Entities
{
    public class EuropeEliminations
    {
        [Key]
        public int Id { get; set; }
        public string Team { get; set; }
        public string HomeResult { get; set; }
        public string AwayResult { get; set; }
        public int Round { get; set; }
        public string NameOfStage { get; set; }
        public string NameOfCompetition { get; set; }

        public int SeasonId { get; set; }
        public virtual Seasons Season { get; set; }
    }
}
