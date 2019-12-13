using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class DatabaseService : IDataBaseService
    {
        private readonly EntityContext _entityContext;

        public DatabaseService(EntityContext context)
        {
            _entityContext = context;
        }

        public async Task<Raid> CreateRaid(Raid raid)
        {
            _entityContext.Raids.Add(raid);

            await _entityContext.SaveChangesAsync();

            return raid;
        }
    }
}
