using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public interface IDataBaseService
    {
        Task<Raid> CreateRaid(Raid raid);
    }
}
