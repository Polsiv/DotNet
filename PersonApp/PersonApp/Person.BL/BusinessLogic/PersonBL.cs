using Person.DAL.Context;
using Person.DAL.DataAccess;

namespace Person.BL.BusinessLogic
{
   
    public class PersonBL
    {
 
        private readonly PersonDal personDal;
        public PersonBL(AppDBContext dbContext)
        {
            personDal = new PersonDal(dbContext);
        }

        public IList<Entities.Models.Person> Get()
        {
            return personDal.Get();
        }

    }
}
