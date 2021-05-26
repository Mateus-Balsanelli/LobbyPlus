using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Model
{
    public class Game
    {
        /// <summary>
        /// Identificados do jogo
        /// </summary>
        public long GameId { get; set; }

        /// <summary>
        /// Nome do jogo
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Genero do jogo
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Descrição do jogo
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// popularidade do jogo
        /// </summary>
        public long Popularity { get; set; }
    }
}
