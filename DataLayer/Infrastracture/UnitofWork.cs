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
        #endregion
    }
}
