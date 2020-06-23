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

        #endregion
    }
}
