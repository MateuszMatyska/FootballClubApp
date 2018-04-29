using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FootballClubApp.BLL.Entities
{
    public class BasicInformations
    {
        [Key]
        public int Id { get; set; }
        public string Information { get; set; }
        public string Data { get; set; }
    }
}