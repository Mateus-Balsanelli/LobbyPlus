using backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Controllers.Interfaces
{
    interface IUserController
    {
        abstract User GetUserByIdInDB(long id);

        abstract User GetUsersInDB();

        abstract void CreateUserInDB(User user);

        abstract void UpdateUserInDB(User user);

        abstract void DeleteUserInDB(long Id);
    }
}
