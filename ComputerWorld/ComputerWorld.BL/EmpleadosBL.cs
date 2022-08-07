using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerWorld.BL
{
    public class EmpleadosBL
    {
        Contexto _contexto;
        public List<Empleado> ListadeEmpleados { get; set; }

        public EmpleadosBL()
        {
            _contexto = new Contexto();
            ListadeEmpleados = new List<Empleado>();
        }

        public List<Empleado> ObtenerEmpleados()
        {
            ListadeEmpleados = _contexto.Empleados
                .OrderBy(r => r.Nombre)
                .ToList();

            return ListadeEmpleados;
        }

        public List<Empleado> ObtenerEmpleadosActivos()
        {
            ListadeEmpleados = _contexto.Empleados
                .Where(r => r.Activo == true)
                .OrderBy(r => r.Nombre)
                .ToList();

            return ListadeEmpleados;
        }

        public void GuardarEmpleado(Empleado empleado)
        {
            if (empleado.Id == 0)
            {
                _contexto.Empleados.Add(empleado);
            }
            else
            {
                var empleadoExistente = _contexto.Empleados.Find(empleado.Id);

                empleadoExistente.Nombre = empleado.Nombre;
                empleadoExistente.Salario = empleado.Salario;
                empleadoExistente.Codigo = empleado.Codigo;
                empleadoExistente.Cargo = empleado.Cargo;
                empleadoExistente.Activo = empleado.Activo;
            }

            _contexto.SaveChanges();
        }

        public Empleado ObtenerEmpleado(int id)
        {
            var empleado = _contexto.Empleados.Find(id);

            return empleado;
        }

        public void EliminarEmpleado(int id)
        {
            var empleado = _contexto.Empleados.Find(id);

            _contexto.Empleados.Remove(empleado);
            _contexto.SaveChanges();
        }
    }
}
