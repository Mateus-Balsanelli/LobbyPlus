using backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Controllers.Interfaces
{
    interface IGameController
    {
        abstract Game GetGameByIdInDB(long id);

        abstract Game GetGamesInDB();

        abstract void CreateGameInDB(Game game);

        abstract void UpdateGameInDB(Game game);

        abstract void DeleteGameInDB(long Id);

    }
}
