using System;
using System.ComponentModel.DataAnnotations;


namespace MvcDentista.Models
{
    public class Paciente

    {

        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        [DataType(DataType.Date)]

        public DateTime FechaAsistencia { get; set; }

        public string Domicilio { get; set; }

        public string Localidad { get; set; }

        public string Profesion { get; set; }

        public int Edad { get; set; }



    }

}

