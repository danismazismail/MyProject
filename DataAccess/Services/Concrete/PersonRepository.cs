using Core.Entities.Concrete;
using DataAccess.Context;
using DataAccess.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services.Concrete
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(AppDbContext context): base(context)
        {            
        }
    }
}
