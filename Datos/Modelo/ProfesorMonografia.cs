using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelo
{
    public class ProfesorMonografia
    {
        [Key]
        public int Id {  get; set; }
        public int ProfesorId { get; set; }    // Clave foránea hacia Profesor
        public Profesor Profesor { get; set; }  // Relación con la entidad Profesor

        public int MonografiaId { get; set; }  // Clave foránea hacia Monografia
        public Monografia Monografia { get; set; }

        public ProfesorMonografia(int profesorId, int monografiaId)
        {
            ProfesorId = profesorId;
            MonografiaId = monografiaId;
        }

        public ProfesorMonografia()
        {
        }
    }

}
