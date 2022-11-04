using GSC_BackEnd_TP.Entities;
using Microsoft.EntityFrameworkCore;

namespace GSC_BackEnd_TP.DataAccess
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        internal DbSet<Person> dbSet;
        public PersonRepository(ThingsContext context)
            : base(context)
        {
            dbSet=context.Set<Person>();
        }
    }
}
