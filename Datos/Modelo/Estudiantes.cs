using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelo
{
    public class Estudiantes
    {
        [Key]
        public int Id { get; set; }
        public string Carnet { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        [Column("AnoNacimiento")]
        public DateTime AnoNacimiento { get; set; }        
        public ICollection<EstudiantesMonografia> Monografia {  get; set; }

        public Estudiantes(string carnet, string nombres, string apellidos, string direccion, string telefono, DateTime anoNacimiento)
        {
            
            Carnet = carnet;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Telefono = telefono;
            AnoNacimiento = anoNacimiento;
        }
        public Estudiantes(int id, string carnet, string nombres, string apellidos, string direccion, string telefono, DateTime anoNacimiento)
        {
            Id = id;
            Carnet = carnet;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Telefono = telefono;
            AnoNacimiento = anoNacimiento;
        }

        public Estudiantes() {
            Monografia = new List<EstudiantesMonografia>();
        }
    }
}
