using FootballClubApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using FootballClubApp.BLL.Entities;
using FootballClubApp.DAL.EF;
using System.Linq;

namespace FootballClubApp.Services.Services
{
    public class BasicInformationService : IBasicInformationService
    {
        private readonly ApplicationDbContext<User,Role,int> _ctx;

        public BasicInformationService(ApplicationDbContext<User, Role, int> ctx)
        {
            _ctx = ctx;
        }

        public bool AddBasicInformation(BasicInformations info)
        {
            try
            {
                _ctx.BasicInformations.Add(info);
                _ctx.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool DeleteBasicInformation(int infoId)
        {
            try
            {
                var item = _ctx.BasicInformations.Single(x => x.Id == infoId);
                _ctx.BasicInformations.Remove(item);
                _ctx.SaveChanges();

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool EditBasicInformation(int infoId, BasicInformations info)
        {
            try
            {
                var oldItem = _ctx.BasicInformations.Single(x => x.Id == infoId);
                oldItem.Information = info.Information;
                oldItem.Data = info.Data;
                _ctx.SaveChanges();

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public List<BasicInformations> GetBasicInformations()
        {
            try
            {
                return _ctx.BasicInformations.ToList();
            }
            catch(Exception)
            {
                return new List<BasicInformations>();
            }
        }

        public BasicInformations GetBasicInfotrmation(int infoId)
        {
            try
            {
                return _ctx.BasicInformations.Single(x => x.Id == infoId);
            }
            catch(Exception)
            {
                return new BasicInformations();
            }
        }
    }
}
