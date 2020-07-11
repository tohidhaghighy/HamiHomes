using DataLayer.Repository.Interfaces;
using DataLayer.Repository.Interfaces.AmlakSetting;
using DataLayer.Repository.Repositories;
using DataLayer.Repository.Repositories.AmlakSetting;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Infrastracture
{
    public class UnitofWork:IUnitofWork
    {
        private IRepository<User> userRepo;
        private IRepository<Log> logRepo;
        private IRepository<Admin> adminRepo;
        private IRepository<City> cityRepo;
        private IRepository<Region> regionRepo;
        private IRepository<HomeGroup> homegroupRepo;
        private IRepository<HomeFacility> homefacilitiRepo;
        private IRepository<Setting> settingRepo;
        private IRepository<Adviser> advisorRepo;
        private IRepository<Magzine> magzineRepo;
        private IRepository<MagzineType> magzinetypeRepo;

        #region amlak setting
        private IRepository<AmlakDivar> amlakdivarRepo;
        private IRepository<AmlakEmtiaz> amlakemtiazRepo;
        private IRepository<AmlakJahatVahed> amlakjahatvahedRepo;
        private IRepository<AmlakKaf> amlakkafRepo;
        private IRepository<AmlakKitchen> amlakkitchenRepo;
        private IRepository<AmlakMelkStatus> amlakmelkstatusRepo;
        private IRepository<AmlakMogheiatMelk> amlakmoghiatemelkRepo;
        private IRepository<AmlakMoshaat> amlakmoshaatRepo;
        private IRepository<AmlakNema> amlaknemaRepo;
        private IRepository<AmlakNoeZamin> amlaknoezaminRepo;
        private IRepository<AmlakParking> amlakparkingRepo;
        private IRepository<AmlakPishraftStatus> amlakpishraftstatusRepo;
        private IRepository<AmlakSaghf> amlaksaghfRepo;
        private IRepository<AmlakSanadStatus> amlaksanadstatusRepo;
        private IRepository<AmlakEskeleton> amlakeskeletonRepo;
        private IRepository<AmlakTasisatGarmaieshi> amlaktasisatgarmaieshRepo;
        private IRepository<AmlakWC> amlakwcRepo;
        #endregion

        private AmlakDbContext db;
        public UnitofWork(AmlakDbContext DbContext)
        {
            db = DbContext;
        }
        public void Commit()
        {
            db.SaveChanges();
        }

        public Task<int> CommitAsync()
        {
            return db.SaveChangesAsync();
        }

        #region dispose
        protected bool disposed = false;


        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                db.Dispose();
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

        #region user
        #region Repository

        public IUserRepository UserRepository
        {
            get
            {
                return new UserRepository(db);
            }
        }

        #endregion

        #region Log
        public ILogRepository LogRepository
        {
            get
            {
                return new LogRepository(db);
            }
        }

        #endregion

        #region admin

        public IAdminRepository AdminRepository
        {
            get
            {
                return new AdminRepository(db);
            }
        }

        #endregion

        #region city
        public ICityRepository CityRepository
        {
            get
            {
                return new CityRepository(db);
            }
        }

        #endregion

        #region region
        public IRegionRepository RegionRepository
        {
            get
            {
                return new RegionRepository(db);
            }
        }

        #endregion

        #region homegroup
        public IHomeGroupRepository HomeGroupRepository
        {
            get
            {
                return new HomeGroupRepository(db);
            }
        }

        #endregion

        #region homefacility
        public IHomeFacilityRepository HomeFacilityRepository
        {
            get
            {
                return new HomeFacilityRepository(db);
            }
        }

        #endregion

        #region Setting
        public ISettingRepository SettingRepository
        {
            get
            {
                return new SettingRepository(db);
            }
        }

        #endregion

        #region Adviser
        public IAdviserRepository AdviserRepository
        {
            get
            {
                return new AdviserRepository(db);
            }
        }

        #endregion

        #region Magzine
        public IMagzineRepository MagzineRepository
        {
            get
            {
                return new MagzineRepository(db);
            }
        }

        #endregion

        #region MagzineType
        public IMagzineTypeRepository MagzineTypeRepository
        {
            get
            {
                return new MagzineTypeRepository(db);
            }
        }

        #endregion

        #endregion


        #region AmlakSetting
        public IAmlakDivarRepository AmlakDivarRepository
        {
            get
            {
                return new AmlakDivarRepository(db);
            }
        }

        public IAmlakEmtiazRepository AmlakEmtiazRepository
        {
            get
            {
                return new AmlakEmtiazRepository(db);
            }
        }

        public IAmlakJahatvahedRepository AmlakJahatvahedRepository
        {
            get
            {
                return new AmlakJahatvahedRepository(db);
            }
        }

        public IAmlakKafRepository AmlakKafRepository
        {
            get
            {
                return new AmlakKafRepository(db);
            }
        }

        public IAmlakKitchenRepository AmlakKitchenRepository
        {
            get
            {
                return new AmlakKitchenRepository(db);
            }
        }

        public IAmlakMelStatusRepository AmlakMelStatusRepository
        {
            get
            {
                return new AmlakMelStatusRepository(db);
            }
        }

        public IAmlakMoghiateMelkRepository AmlakMoghiateMelkRepository
        {
            get
            {
                return new AmlakMoghiateMelkRepository(db);
            }
        }

        public IAmlakMoshaatRepository AmlakMoshaatRepository
        {
            get
            {
                return new AmlakMoshaatRepository(db);
            }
        }

        public IAmlakMoshakhaseRepository AmlakMoshakhaseRepository
        {
            get
            {
                return new AmlakMoshakhaseRepository(db);
            }
        }

        public IAmlakNemaRepository AmlakNemaRepository
        {
            get
            {
                return new AmlakNemaRepository(db);
            }
        }

        public IAmlakNoeZaminRepository AmlakNoeZaminRepository
        {
            get
            {
                return new AmlakNoeZaminRepository(db);
            }
        }

        public IAmlakParkingRepository AmlakParkingRepository
        {
            get
            {
                return new AmlakParkingRepository(db);
            }
        }

        public IAmlakPishraftStatusRepository AmlakPishraftStatusRepository
        {
            get
            {
                return new AmlakPishraftStatusRepository(db);
            }
        }

        public IAmlakSaghfRepository AmlakSaghfRepository
        {
            get
            {
                return new AmlakSaghfRepository(db);
            }
        }

        public IAmlakSanadStatusRepository AmlakSanadStatusRepository
        {
            get
            {
                return new AmlakSanadStatusRepository(db);
            }
        }

        public IAmlakSkeletonRepository AmlakSkeletonRepository
        {
            get
            {
                return new AmlakSkeletonRepository(db);
            }
        }

        public IAmlakTasisatGarmaieshiRepository AmlakTasisatGarmaieshiRepository
        {
            get
            {
                return new AmlakTasisatGarmaieshiRepository(db);
            }
        }

        public IAmlakWcRepository AmlakWcRepository
        {
            get
            {
                return new AmlakWcRepository(db);
            }
        }


        #endregion
    }
}
