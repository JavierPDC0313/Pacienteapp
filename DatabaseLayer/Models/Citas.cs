using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Models
{
    public class Citas
    {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public int IdDoctor { get; set; }
        public DateTime FechaHora { get; set; } = new DateTime();
        public string Causa { get; set; }
        public int Estado { get; set; }
    }
}
