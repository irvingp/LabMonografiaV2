using CapaDatos.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelo
{
    public class Monografia
    {
        public Monografia()
        {
            Profesores = new List<ProfesorMonografia>();
            Estudiantes = new List<EstudiantesMonografia>();
            Tutor = new List<TutorMonografia>();
        }

        [Key]
        public int IdMonografia { get; set; }
        public string TituloMonografia { get; set; }
        public DateTime FechaDeDefensa { get; set; }
        public double NotaDeDefensa { get; set; }
        public double TiempoOtorgado { get; set; }
        public double TiempoDeDefensa { get; set; }
        public double TiempoDeQyA { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        public ICollection<EstudiantesMonografia> Estudiantes { get; set; }
        public ICollection<ProfesorMonografia> Profesores { get; set; }

        public ICollection<TutorMonografia> Tutor { get; set; }

        public Monografia(string tituloMonografia, DateTime fechaDeDefensa, double notaDeDefensa, double tiempoOtorgado, double tiempoDeDefensa, double tiempoDeQyA, DateTime fechaCreacion)
        {
            TituloMonografia = tituloMonografia;
            FechaDeDefensa = fechaDeDefensa;
            NotaDeDefensa = notaDeDefensa;
            TiempoOtorgado = tiempoOtorgado;
            TiempoDeDefensa = tiempoDeDefensa;
            TiempoDeQyA = tiempoDeQyA;
            FechaCreacion = fechaCreacion;
        }
    }
}
