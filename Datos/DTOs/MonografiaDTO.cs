using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.DTOs
{
    public class MonografiaDTO
    {
        public DateTime FechaCreacion { get; set; }
        public string TituloMonografia { get; set; }
        public string EstudianteNombres { get; set; }
        public string EstudianteApellidos { get; set; }
        public string TutorNombres { get; set; }
        public string TutorApellidos { get; set; }
    }
}
