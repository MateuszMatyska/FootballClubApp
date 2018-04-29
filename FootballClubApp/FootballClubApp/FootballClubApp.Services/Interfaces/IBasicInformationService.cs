using FootballClubApp.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballClubApp.Services.Interfaces
{
    public interface IBasicInformationService
    {
        List<BasicInformations> GetBasicInformations();
        BasicInformations GetBasicInfotrmation(int infoId);
        bool AddBasicInformation(BasicInformations info);
        bool EditBasicInformation(int infoId, BasicInformations info);
        bool DeleteBasicInformation(int infoId);
    }
}
