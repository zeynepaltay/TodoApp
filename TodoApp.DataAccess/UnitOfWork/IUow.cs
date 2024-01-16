using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.DataAccess.Interfaces;
using TodoApp.Entities.Domains;

namespace TodoApp.DataAccess.UnitOfWork
{
    public interface IUow
    {
        IRepository<T> GetRepository<T>() where T : BaseEntity;

        Task SaveChanges();
    }
}
