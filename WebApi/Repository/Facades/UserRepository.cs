using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Entities;

namespace WebApi.Repository.Facades
{
    public class UserRepository : DefaultRepository<User>
    {
        public UserRepository() : base()
        {

        }
    }
}
