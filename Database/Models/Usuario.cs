using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Models
{
    public class Usuario
    {

        public int id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Correo { get; set; }

        public string Nombre_Usuario { get; set; }

        public string Contraseña { get; set; }

        public string TipoUsuario { get; set; }

    }
}
