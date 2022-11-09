using GSC_BackEnd_TP.Entities;
using Microsoft.EntityFrameworkCore;

namespace GSC_BackEnd_TP.DataAccess
{
    public class ThingRepository : GenericRepository<Thing>, IThingRepository
    {
        internal DbSet<Thing> dbSet;
        public ThingRepository(ThingsContext context)
            : base(context)
        {
            dbSet = context.Set<Thing>();
        }
    }
}
