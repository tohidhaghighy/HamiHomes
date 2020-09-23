using DataLayer.Repository.Interfaces;
using DataLayer.Repository.Interfaces.AmlakSetting;
using DataLayer.Repository.Interfaces.Contract;
using DataLayer.Repository.Interfaces.Home;
using DataLayer.Repository.Interfaces.Location;
using DataLayer.Repository.Interfaces.Magazin;
using DataLayer.Repository.Interfaces.Sazande;
using DataLayer.Repository.Interfaces.Setting;
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
        ISazandeRepository SazandeRepository { get; }
        ISazandeGallery SazandeGalleryRepository { get; }
        IHomeSazandeRepository HomeSazandeRepository { get; }
        IUserRepository UserRepository { get; }
        ILogRepository LogRepository { get; }
        IAdminRepository AdminRepository { get; }
        INahieRepository NahieRepository { get; }
        INahieDirectionRepository NahieDirectionRepository { get; }
        IMahalleRepository MahalleRepository { get; }
        ICityRepository CityRepository { get; }
        IRegionRepository RegionRepository { get; }
        IHomeFacilityRepository HomeFacilityRepository { get; }
        IHomeGroupRepository HomeGroupRepository { get; }
        ISettingRepository SettingRepository { get; }
        IAdviserRepository AdviserRepository { get; }
        IMagazinRepository MagazinRepository { get; }
        IMagazinGroupRepository MagazinGroupRepository { get; }
        IContractRepository ContractRepository { get; }

        #region Home
        IHomeRepository HomeRepository { get; }
        IHomeGalleryRepository HomeGalleryRepository { get; }
        IGardenWithVilaRepository GardenWithVilaRepository { get; }
        IHomeAnbarRepository HomeAnbarRepository { get; }
        IHomeApartemanRepository HomeApartemanRepository { get; }
        IHomeEdariRepository HomeEdariRepository { get; }
        IHomeGardenRepository HomeGardenRepository { get; }
        IHomeKolangiRepository HomeKolangiRepository { get; }
        IHomeWithGardenRepository HomeWithGardenRepository { get; }
        IMaghazeRepository MaghazeRepository { get; }
        IMoshtghelatRepository MoshtghelatRepository { get; }
        IVilaRepository VilaRepository { get; }
        IZaminRepository ZaminRepository { get; }

        #endregion

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

        ICostSettingRepository CostSettingRepository { get; }
        IMetrazSettingRepository MetrazSettingRepository { get; }
        IVadieSettingRepository VadieSettingRepository { get; }
        IEjareSettingRepository EjareSettingRepository { get; }
        ICustomerRepository CustomerRepository { get; }

        void Commit();

        Task<int> CommitAsync();
    }
}
