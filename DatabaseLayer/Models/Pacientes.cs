using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseLayer.Models
{
    public class Pacientes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Cedula { get; set; }
        public DateTime FechaNacimiento { get; set; } = new DateTime();
        public int Fumador { get; set; }
        public string Alergias { get; set; }
        public string Foto { get; set; }
    }
}
