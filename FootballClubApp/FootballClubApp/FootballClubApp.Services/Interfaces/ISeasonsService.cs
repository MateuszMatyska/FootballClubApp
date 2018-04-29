using FootballClubApp.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballClubApp.Services.Interfaces
{
    public interface ISeasonsService
    {
        bool AddSeason(Seasons season);
        bool DeleteSeason(int seasonId);
        Seasons GetSeason(int seasonId);
        List<Seasons> GetSeasons();
    }
}
