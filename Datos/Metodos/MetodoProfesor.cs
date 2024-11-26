using CapaDatos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Metodos
{
    public  class MetodoProfesor
    {
        public void Insertar(Profesor estudiante)
        {

            using (var context = new LabMonografiaContext())
            {
                context.Profesor.Add(estudiante);
                context.SaveChanges();

            }

        }
        public void Modificar(Profesor estudiante)
        {
            using (var context = new LabMonografiaContext())
            {

                context.Entry(estudiante).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Eliminar(int Id)
        {
            using (var context = new LabMonografiaContext())
            {

                var estudiante = (Profesor)context.Profesor.Find(Id);
                if (estudiante != null)
                {
                    context.Profesor.Remove(estudiante);
                    context.SaveChanges();

                }

            }
        }

        public Profesor BucarPorID(int id)
        {

            Profesor Estudiante;

            using (var context = new LabMonografiaContext())
            {

                Estudiante = (Profesor)context.Profesor.Where(x => x.Id == id);

            }
            return Estudiante;
        }

        public List<Profesor> ObtenerTodo()
        {
            List<Profesor> Lista;
            using (var context = new LabMonografiaContext())
            {

                Lista = context.Profesor.ToList();

            }
            return Lista;

        }

        public List<Profesor> BuscarPorNombre(string Nombre)
        {
            List<Profesor> Lista;
            using (var context = new LabMonografiaContext())
            {

                Lista = context.Profesor.Where(x => x.Nombres.Contains(Nombre)).ToList();

            }
            return Lista;
        }

        public List<Profesor> BuscarPorRol(string Rol)
        {

            List<Profesor> Lista;
            using (var context = new LabMonografiaContext())
            {

                Lista = context.Profesor.Where(x => x.Rol== Rol).ToList();

            }
            return Lista;
        }
        public Profesor BuscarProfesorPorId(int Id)
        {

            Profesor profe;
            using (var context = new LabMonografiaContext())
            {

                profe = context.Profesor.First(x => x.Id == Id);

            }
            return profe;
        }

    }
}
