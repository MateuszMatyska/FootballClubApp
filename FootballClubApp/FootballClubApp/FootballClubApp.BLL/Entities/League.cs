using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FootballClubApp.BLL.Entities
{
    public abstract class League
    {
        [Key]
        public int Id { get; set; }

        public int SeasonId { get; set; }
        public virtual Seasons Season { get; set; }
    }
}
