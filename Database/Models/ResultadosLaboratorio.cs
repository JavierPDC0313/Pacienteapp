using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Models
{
    public class ResultadosLaboratorio
    {

        public int id { get; set; }

        public int IdPaciente { get; set; }

        public int IdCita { get; set; }

        public int IdPruebaLaboratorio { get; set; }

        public int IdMedico { get; set; }

        public string Resultado { get; set; }

        public int EstadoResultado { get; set; }


    }
}
