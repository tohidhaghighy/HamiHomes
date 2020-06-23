using DataLayer.Repository.Interfaces;
using DataLayer.Repository.Repositories;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Infrastracture
{
    public interface IUnitofWork
    {
        IUserRepository UserRepository { get; }
        ILogRepository LogRepository { get; }
        IAdminRepository AdminRepository { get; }
        ICityRepository CityRepository { get; }
        IRegionRepository RegionRepository { get; }
        IHomeFacilityRepository HomeFacilityRepository { get; }
        IHomeGroupRepository HomeGroupRepository { get; }
        ISettingRepository SettingRepository { get; }

        void Commit();

        Task<int> CommitAsync();
    }
}
