using DataLayer.Repository.Interfaces;
using DataLayer.Repository.Interfaces.AmlakSetting;
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
        IAdviserRepository AdviserRepository { get; }
        IMagzineRepository MagzineRepository { get; }
        IMagzineTypeRepository MagzineTypeRepository { get; }

        #region amlak setting
        IAmlakDivarRepository AmlakDivarRepository { get; }
        IAmlakEmtiazRepository AmlakEmtiazRepository { get; }
        IAmlakJahatvahedRepository AmlakJahatvahedRepository { get; }
        IAmlakKafRepository AmlakKafRepository { get; }
        IAmlakKitchenRepository AmlakKitchenRepository { get; }
        IAmlakMelStatusRepository AmlakMelStatusRepository { get; }
        IAmlakMoghiateMelkRepository AmlakMoghiateMelkRepository { get; }
        IAmlakMoshaatRepository AmlakMoshaatRepository { get; }
        IAmlakMoshakhaseRepository AmlakMoshakhaseRepository { get; }
        IAmlakNemaRepository AmlakNemaRepository { get; }
        IAmlakNoeZaminRepository AmlakNoeZaminRepository { get; }
        IAmlakParkingRepository AmlakParkingRepository { get; }
        IAmlakPishraftStatusRepository AmlakPishraftStatusRepository { get; }
        IAmlakSaghfRepository AmlakSaghfRepository { get; }
        IAmlakSanadStatusRepository AmlakSanadStatusRepository { get; }
        IAmlakSkeletonRepository AmlakSkeletonRepository { get; }
        IAmlakTasisatGarmaieshiRepository AmlakTasisatGarmaieshiRepository { get; }
        IAmlakWcRepository AmlakWcRepository { get; }
        #endregion

        void Commit();

        Task<int> CommitAsync();
    }
}
