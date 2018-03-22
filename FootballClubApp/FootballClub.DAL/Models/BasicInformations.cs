using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FootballClub.DAL.Models
{
    public class BasicInformations
    {
        [Key]
        public int InformationId { get; set; }
        public string Information { get; set;}
        public string Data { get; set; }
    }
}
