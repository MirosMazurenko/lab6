using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusLib.Repositories.Interfaces;

namespace BusLib.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IBusRepository Busses { get; }
        IUserRepository Users { get; }
        void Save();
    }
}
