using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusLib.EF;
using BusLib.Entities;
using BusLib.Repositories.Interfaces;

namespace BusLib.Repositories.Implementation
{
    public class BusRepository : BaseRepository<Bus>, IBusRepository
    {
        public BusRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
