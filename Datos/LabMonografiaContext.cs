using CapaDatos.Modelo;
using System.Configuration;
using System.Data.Entity;

namespace CapaDatos
{
    public class LabMonografiaContext : DbContext
    {
        public LabMonografiaContext():base(GetConnectionString()) { }

        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Profesor> Profesor { get; set; }
        public DbSet<Monografia> Monografia { get; set; }

        public DbSet<EstudiantesMonografia> EstudiantesMonografia { get; set; }
        public DbSet<ProfesorMonografia> ProfesorMonografias { get; set; }
        public DbSet<TutorMonografia> TutorMonografias { get; set; }

        private static string GetConnectionString()
        {
            // Lee la cadena de conexión desde el archivo de configuración de `presentacion`
            return ConfigurationManager.ConnectionStrings["LabMonografiaV2"].ConnectionString;
        }
    }
}

