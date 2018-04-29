using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FootballClubApp.BLL.Entities
{
    public class Coaches
    {
        [Key]
        public int Id { get; set; }
        public string Name { get;set;}

        public int SeasonId { get; set; }
        public Seasons Season { get; set; }
    }
}
