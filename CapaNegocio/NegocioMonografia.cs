using CapaDatos.DTOs;
using CapaDatos.Metodos;
using CapaDatos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioMonografia
    {
        public CapaDatos.Metodos.MetodosMonografia Metodos = new CapaDatos.Metodos.MetodosMonografia();


        public int InsertarMonografia(Monografia monografia, List<Estudiantes> estudiantes, List<Profesor> profesor, List<Profesor> tutor)
        {
          return  Metodos.Insertar(monografia,estudiantes, profesor, tutor);
        }

        public List<MonografiaEstudianteDTO> BuscarPorCarne(String Carnet)
        {
            return Metodos.BuscarPorCarnet(Carnet);
        }

        public List<Object> EstudiantesConMonografias()
        {
            return Metodos.EstudiantesConMonografias();
        }

        public List<MonografiaEstudianteDTO> BuscarPorIdMonografia(int Id)
        {

            return Metodos.BuscarPorIdMonografia(Id);
        }

        public List<MonografiaEstudianteDTO> BuscarporIdTutor(int Id)
        {

            return Metodos.BuscarPorTutor(Id);
        }

        public List<MonografiaDTO> ObtenerMonografiasConFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            return Metodos.ObtenerMonografiasConFecha(fechaInicio, fechaFin);
        }

        public List<MonografiaDTO> ObtenerMonografiasConFechayProfesor(DateTime fechaInicio, DateTime fechaFin, int IdProfesor)
        {
            return Metodos.ObtenerMonografiasConFechayProfesor(fechaInicio,fechaFin,IdProfesor);
        }
    }
}
