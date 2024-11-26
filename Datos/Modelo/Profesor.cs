using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelo
{
    public class Profesor
    {
        public Profesor()
        {
            monografias = new List<ProfesorMonografia>();
        }

        [Key]
        public int Id{ get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime AñoDeNacimiento { get; set; }
        public string Rol { get; set; }
        public ICollection<ProfesorMonografia> monografias { get; set; }

        public Profesor(int id, string nombres, string apellidos, string direccion, string telefono, DateTime añoDeNacimiento, string rol)
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Telefono = telefono;
            AñoDeNacimiento = añoDeNacimiento;
            Rol = rol;
        }

        public Profesor(string nombres, string apellidos, string direccion, string telefono, DateTime añoDeNacimiento, string rol)
        {
            
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Telefono = telefono;
            AñoDeNacimiento = añoDeNacimiento;
            Rol = rol;
        }

    }


}
