using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Models
{
    public class ResultadosLaboratorio
    {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public int IdCita { get; set; }
        public int IdPruebaLaboraratorio { get; set; }
        public int IdDoctor { get; set; }
        public string Resultado { get; set; }
        public int EstadoResultado { get; set; }
    }
}
