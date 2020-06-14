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

        void Commit();

        Task<int> CommitAsync();
    }
}
