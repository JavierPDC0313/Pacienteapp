using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Models
{
    public class Citas
    {

        public int id { get; set; }

        public int IdPaciente { get; set; }

        public int IdDoctor { get; set; }

        public DateTime Fecha_HoraCita { get; set; }

        public string CausaCita { get; set; }

        public int EstadoCita { get; set; }

    }
}
