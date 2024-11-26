using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelo
{
    public class TutorMonografia
    {

        public TutorMonografia()
        {
        }

        [Key]
        public int Id { get; set; }
        public int TutorId { get; set; }   // Clave foránea hacia Estudiantes
        public Profesor Tutor { get; set; } // Relación con la entidad Estudiantes

        public int MonografiaId { get; set; }   // Clave foránea hacia Monografia
        public Monografia Monografia { get; set; }

        public TutorMonografia(int tutorId, int monografiaId)
        {
            TutorId = tutorId;
            MonografiaId = monografiaId;
        }
    }
}
