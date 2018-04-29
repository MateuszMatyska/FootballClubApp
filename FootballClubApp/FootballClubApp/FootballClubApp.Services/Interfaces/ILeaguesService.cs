using FootballClubApp.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballClubApp.Services.Interfaces
{
    public interface ILeaguesService
    {
        bool AddLeagueRecord<T>(int seasonId, T record) where T : League;
        bool EditCountryLeagueRecord(int seasonId, int recordId, CountryLeague record);
        bool EditEuropeLeagueRecord(int seasonId, int recordId, EuropeLeague record);
        bool DeleteLeagueRecord<T>(int seasonId, int recordId) where T : League;
        T GetLeagueRecord<T>(int seasonId, int recordId) where T : League;
        IEnumerable<T> GetLeagueRecords<T>(int seasonId) where T : League;
    }
}
