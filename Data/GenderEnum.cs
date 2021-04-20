using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LobbyPlus.Data
{
    public enum GenderEnum : byte
    {
        [Description("Action")]
        Action = 1,
        [Description("Horror")]
        Horror = 2,
        [Description("Role Playing Game")]
        RPG = 3,
        [Description("Adventure")]
        Adventure = 4,
        [Description("First Person Shooter")]
        FPS = 5,
        [Description("Massively Multiplayer Online")]
        MMO = 6,
        [Description("Player VS Player")]
        PvP = 7,
        [Description("Player VS Environment")]
        PvE = 8,

    }
}
