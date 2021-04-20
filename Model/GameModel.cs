using LobbyPlus.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LobbyPlus.Model
{
    public class GameModel
    {
        public long GameId { get; set; }

        public string Name { get; set; }

        public GenderEnum Gender { get; set; }

        public string Description { get; set; }

    }
}
