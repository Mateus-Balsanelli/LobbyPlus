using backend.Controllers.Interfaces;
using backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Controllers
{
    public class UserController : IUserController
    {
        public void CreateUserInDB(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUserInDB(long Id)
        {
            throw new NotImplementedException();
        }

        public User GetUserByIdInDB(long id)
        {
            throw new NotImplementedException();
        }

        public User GetUsersInDB()
        {
            throw new NotImplementedException();
        }

        public void UpdateUserInDB(User user)
        {
            throw new NotImplementedException();
        }
    }
}
