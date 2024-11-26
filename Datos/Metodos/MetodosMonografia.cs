using CapaDatos.DTOs;
using CapaDatos.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CapaDatos.Metodos
{
   




    public class MetodosMonografia
    {
        public int Insertar(Monografia monografia, List<Estudiantes> estudiantes, List<Profesor> profesores, List<Profesor> Tutor)
        {
            using (var context = new LabMonografiaContext())
            {
                
               
                            // Primero, agregamos la monografía al contexto y la guardamos para obtener la Id
                context.Monografia.Add(monografia);


                context.SaveChanges(); // Esto guarda la monografía y genera su Id automáticamente

                // Obtener la última monografía insertada (usando la fecha de creación o IdMonografia)
                var mono = context.Monografia
                                  .OrderByDescending(m => m.FechaCreacion) // O puedes usar OrderByDescending(m => m.IdMonografia)
                                  .FirstOrDefault();

                if (mono != null)
                {
                    // Agregar estudiantes a la monografía
                    foreach (var estudiante in estudiantes)
                    {
                        // Busca si el estudiante existe en la base de datos
                        var estudianteExistente = context.Estudiantes.FirstOrDefault(e => e.Id == estudiante.Id);
                        if (estudianteExistente != null)
                        {
                            // Crear la relación entre el estudiante y la monografía
                            EstudiantesMonografia EM = new EstudiantesMonografia(estudianteExistente.Id,mono.IdMonografia);
                            context.EstudiantesMonografia.Add (EM);
                        }
                    }

                    // Agregar profesores a la monografía
                    foreach (var profesor in profesores)
                    {
                        // Busca si el profesor existe en la base de datos
                        var profesorExistente = context.Profesor.FirstOrDefault(p => p.Id == profesor.Id);
                        if (profesorExistente != null)
                        {
                            // Crear la relación entre el profesor y la monografía
                            ProfesorMonografia PM = new ProfesorMonografia(profesorExistente.Id, mono.IdMonografia);
                            context.ProfesorMonografias.Add (PM);
                        }
                    }

                    foreach (var tutor in Tutor)
                    {
                        // Busca si el estudiante existe en la base de datos
                        var tutorExiste = context.Profesor.FirstOrDefault(e => e.Id == tutor.Id);
                        if (tutorExiste != null)
                        {
                            // Crear la relación entre el estudiante y la monografía
                            TutorMonografia TM = new TutorMonografia(tutorExiste.Id, mono.IdMonografia);
                            context.TutorMonografias.Add(TM);
                        }
                    }

                    // Guardar los cambios en la base de datos
                    return context.SaveChanges();
                }
                else
                {
                    // Si no se encontró la monografía, se puede manejar un error o devolver un valor especial
                    throw new InvalidOperationException("No se pudo encontrar la monografía recién insertada.");
                }
            }
        }


        public List<object> EstudiantesConMonografias()
        {

            using (var context = new LabMonografiaContext())
            {
                var resultado = context.EstudiantesMonografia.Select(m => new { m.Estudiante.Id, m.Estudiante.Nombres }).ToList();
                return resultado.Cast<object>().ToList();
            }

        }

        public List<MonografiaEstudianteDTO> BuscarPorCarnet(string carnet)
        {
            using (var context = new LabMonografiaContext())
            {
                var resultado = from em in context.EstudiantesMonografia
                                join e in context.Estudiantes on em.EstudianteId equals e.Id
                                join m in context.Monografia on em.MonografiaId equals m.IdMonografia
                                where e.Carnet == carnet
                                select new MonografiaEstudianteDTO
                                {
                                    TituloMonografia = m.TituloMonografia,
                                    NotaDeDefensa = m.NotaDeDefensa,
                                    NombresEstudiante = e.Nombres,
                                    ApellidosEstudiante = e.Apellidos
                                };

                return resultado.ToList();

                
            }
        }

        public List<MonografiaEstudianteDTO> BuscarPorIdMonografia(int Id)
        {
            using (var context = new LabMonografiaContext())
            {
                var resultado = from em in context.EstudiantesMonografia
                                join e in context.Estudiantes on em.EstudianteId equals e.Id
                                join m in context.Monografia on em.MonografiaId equals m.IdMonografia
                                where m.IdMonografia == Id
                                select new MonografiaEstudianteDTO
                                {
                                    TituloMonografia = m.TituloMonografia,
                                    NotaDeDefensa = m.NotaDeDefensa,
                                    NombresEstudiante = e.Nombres,
                                    ApellidosEstudiante = e.Apellidos
                                };

                return resultado.ToList();


            }
        }

        public List<MonografiaEstudianteDTO> BuscarPorTutor(int IdTutor)
        {
            using (var context = new LabMonografiaContext())
            {
                // LINQ para replicar la consulta SQL
                var resultado = from monografia in context.Monografia
                                join tutorMonografia in context.TutorMonografias on monografia.IdMonografia equals tutorMonografia.MonografiaId
                                join estudiantesMonografia in context.EstudiantesMonografia on monografia.IdMonografia equals estudiantesMonografia.MonografiaId
                                join estudiante in context.Estudiantes on estudiantesMonografia.EstudianteId equals estudiante.Id
                                where tutorMonografia.TutorId == IdTutor
                                select new MonografiaEstudianteDTO
                                {
                                    TituloMonografia = monografia.TituloMonografia,
                                    NotaDeDefensa = monografia.NotaDeDefensa,
                                    NombresEstudiante = estudiante.Nombres,
                                    ApellidosEstudiante = estudiante.Apellidos
                                };

                return resultado.ToList();
            }
        }

        public List<MonografiaDTO> ObtenerMonografiasConFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            using (var context = new LabMonografiaContext())
            {
                var query = from monografia in context.Monografia
                            join em in context.EstudiantesMonografia on monografia.IdMonografia equals em.MonografiaId
                            join estudiante in context.Estudiantes on em.EstudianteId equals estudiante.Id
                            join tm in context.TutorMonografias on monografia.IdMonografia equals tm.MonografiaId
                            join tutor in context.Profesor on tm.TutorId equals tutor.Id
                            where monografia.FechaCreacion >= fechaInicio && monografia.FechaCreacion <= fechaFin
                            select new MonografiaDTO
                            {
                                FechaCreacion = monografia.FechaCreacion,
                                TituloMonografia = monografia.TituloMonografia,
                                EstudianteNombres = estudiante.Nombres,
                                EstudianteApellidos = estudiante.Apellidos,
                                TutorNombres = tutor.Nombres,
                                TutorApellidos = tutor.Apellidos
                            };

                return query.ToList();
            }
        }

        public List<MonografiaDTO> ObtenerMonografiasConFechayProfesor(DateTime fechaInicio, DateTime fechaFin, int IdProfesor)
        {
            using (var context = new LabMonografiaContext())
            {
                var query = from monografia in context.Monografia
                            join em in context.EstudiantesMonografia on monografia.IdMonografia equals em.MonografiaId
                            join estudiante in context.Estudiantes on em.EstudianteId equals estudiante.Id
                            join tm in context.TutorMonografias on monografia.IdMonografia equals tm.MonografiaId
                            join tutor in context.Profesor on tm.TutorId equals tutor.Id
                            where monografia.FechaCreacion >= fechaInicio && monografia.FechaCreacion <= fechaFin
                            && tutor.Id == IdProfesor  
                            select new MonografiaDTO
                            {
                                FechaCreacion = monografia.FechaCreacion,
                                TituloMonografia = monografia.TituloMonografia,
                                EstudianteNombres = estudiante.Nombres,
                                EstudianteApellidos = estudiante.Apellidos,
                                TutorNombres = tutor.Nombres,
                                TutorApellidos = tutor.Apellidos,
                                
                            };

                
                var resultado = query.ToList();

                
                return resultado;
            }
        }
    }
}
