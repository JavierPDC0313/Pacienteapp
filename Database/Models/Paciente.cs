using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Models
{
    public class Paciente
    {

        public int id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get;  set; }

        public string Cedula { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int Fumador { get; set; }

        public string Alergias { get; set; }

        public string Foto { get; set; }

    }
}
