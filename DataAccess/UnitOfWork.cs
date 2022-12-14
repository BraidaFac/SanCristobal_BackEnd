namespace GSC_BackEnd_TP.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ThingsContext context;
        //public IThingRepository ThingRepository { get; private set; }
        //public ILoanRepository LoanRepository { get; private set; }

        public IPersonRepository PersonRepository { get; private set; }
        public IThingRepository ThingRepository { get; private set; }
        // public ICategoryRepository CategoryRepository { get; private set; }
    
    public UnitOfWork(ThingsContext context)
    {
        this.context = context;
        //ThingRepository = new ThingRepository(context);
        // LoanRepository = new LoanRepository(context);
        // CategoryRepository = new CategoryRepository(context);
        PersonRepository = new PersonRepository(context);
    }
   public int Complete()
      {
         return context.SaveChanges();
        }
    }
}
