using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace backend.Model
{
    public class User
    {
        /// <summary>
        /// Código do participante (Identity)
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// nome do usuário
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Email do Usuário
        /// </summary>
        public string Email { get; set; } 

        /// <summary>
        /// Senha do usuário
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Data de registro do usuário
        /// </summary>
        public DateTime Registered { get; set; }

        /// <summary>
        /// Genero de jogo preferido
        /// </summary>
        public string GenrePreferred { get; set; }

        /// <summary>
        /// Verifica se o usuário é um administrador
        /// </summary>
        public bool Admin { get; set; }
    }
}