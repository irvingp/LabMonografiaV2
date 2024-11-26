using CapaDatos.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Metodos
{
    public class MetodoEstudiante
    {
        public void Insertar(Estudiantes estudiante) {

            using (var context = new LabMonografiaContext())
            {
                context.Estudiantes.Add(estudiante);
                context.SaveChanges();

            }

        }
        public void Modificar(Estudiantes estudiante)
        {
            using (var context = new LabMonografiaContext()) {

                context.Entry(estudiante).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Eliminar(int Id)
        {
            using (var context = new LabMonografiaContext())
            {

                var estudiante = (Estudiantes)context.Estudiantes.Find(Id);
                if (estudiante != null)
                {
                    context.Estudiantes.Remove(estudiante);
                    context.SaveChanges();

                }

            }
        }

        public Estudiantes BucarPorID(int id) {

            Estudiantes Estudiante;

            using (var context = new LabMonografiaContext())
            {

                Estudiante = (Estudiantes)context.Estudiantes.Where(x => x.Id == id);

            }
            return Estudiante;
        }

        public List<Estudiantes> ObtenerTodo() {
            List<Estudiantes> Lista;
            using (var context = new LabMonografiaContext())
            {

                Lista = context.Estudiantes.ToList();

            }
            return Lista;

        }

        public List <Estudiantes> BuscaPorCarnet(string Carnet) {
            List<Estudiantes> Lista;
            using (var context = new LabMonografiaContext())
            {

                Lista = context.Estudiantes.Where(x=>x.Carnet == Carnet).ToList();

            }
            return Lista;
        }

        public Estudiantes BuscarEstudiantePorId(int Id)
        {
            Estudiantes Estudiante;

            using (var context = new LabMonografiaContext())
            {

                Estudiante = context.Estudiantes.First(x => x.Id == Id);
            }
            return Estudiante;
        }
    }
}
