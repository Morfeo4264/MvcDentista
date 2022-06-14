using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDentista.Models
{
    public class Turno
    {
        public int IdTurno { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string CorreoElectronico { get; set; }

        public DateTime FechaTurno { get; set; }

        public string Comentario { get; set; }
    }
}
