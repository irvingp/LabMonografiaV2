using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelo
{
    public class EstudiantesMonografia
    {
        public EstudiantesMonografia()
        {
        }

        [Key]
        public int Id { get; set; }
        public int EstudianteId { get; set; }   // Clave foránea hacia Estudiantes
        public Estudiantes Estudiante { get; set; } // Relación con la entidad Estudiantes

        public int MonografiaId { get; set; }   // Clave foránea hacia Monografia
        public Monografia Monografia { get; set; }

        public EstudiantesMonografia(int estudianteId, int monografiaId)
        {
            EstudianteId = estudianteId;
            MonografiaId = monografiaId;
        }
    }
}
