using CapaDatos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioEstudiante
    {
        public CapaDatos.Metodos.MetodoEstudiante Metodos = new CapaDatos.Metodos.MetodoEstudiante();

      
        public void InsertarEstudiante(Estudiantes estudiante)
        { 
            Metodos.Insertar(estudiante);
        }

        public void ModificarEstudiante(Estudiantes estudiante)
        {
            Metodos.Modificar(estudiante);
        }
        public void Eliminar(int Id)
        {
            Metodos.Eliminar(Id);
        }
        public void BuscarEstudianteXId(int  Id)
        {
            Metodos.BucarPorID(Id);
        }

        public List<Estudiantes> ObtenerTodosEstudiantes()
        {
            return Metodos.ObtenerTodo();
        }

        public List<Estudiantes> BuscarPorCarent(string Carnet)
        {
            return Metodos.BuscaPorCarnet(Carnet);
        }

        public Estudiantes BuscarEstudianePorId(int Id)
        {
            return Metodos.BuscarEstudiantePorId(Id);
        }
    }
}
