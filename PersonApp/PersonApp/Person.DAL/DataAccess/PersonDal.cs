using Person.DAL.Context;

namespace Person.DAL.DataAccess
{
    public class PersonDal
    {
        public readonly AppDBContext _dbContext;
        public PersonDal(AppDBContext dbContext)
        {
            _dbContext = dbContext;   
        }

        public IList<Entities.Models.Person> Get()
        {
            return _dbContext.Persons.ToList();
        }

    }
}
