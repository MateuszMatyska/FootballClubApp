using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FootballClubApp.BLL.Entities
{
    public class Seasons
    {
        [Key]
        public int Id { get; set; }
        public string Season { get; set; }

        public virtual ICollection<EuropeEliminations> GetEuropeEliminations { get; set; }
        public virtual ICollection<EuropeLeague> EuropeLeague { get; set; }
        public virtual ICollection<CountryLeague> League { get; set; }
        public virtual ICollection<Coaches> Coaches { get; set; }
    }
}
