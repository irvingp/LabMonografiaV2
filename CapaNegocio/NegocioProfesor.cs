using CapaDatos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioProfesor
    {
        private CapaDatos.Metodos.MetodoProfesor Metodos = new CapaDatos.Metodos.MetodoProfesor();


        public void InsertarProfesor(Profesor profesor)
        {
            Metodos.Insertar(profesor);
        }

        public void ModificarEstudiante(Profesor profesor)
        {
            Metodos.Modificar(profesor);
        }
        public void Eliminar(int Id)
        {
            Metodos.Eliminar(Id);
        }
        public void BucarProfesorPorID(int Id)
        {
            Metodos.BucarPorID(Id);
        }

        public List<Profesor> ObenerTodosProfesor()
        {
            return Metodos.ObtenerTodo();
        }

        public List<Profesor> BuscarProfesorPorNombre(string Nombre)
        {
            return Metodos.BuscarPorNombre(Nombre);
       }

        public List<Profesor> BuscarProfesorPorRol(string Rol)
        {
            return Metodos.BuscarPorRol(Rol);
        }

        public Profesor BuscarProfesorPorId(int Id)
        {
            return Metodos.BuscarProfesorPorId(Id);
        }
    }
}
