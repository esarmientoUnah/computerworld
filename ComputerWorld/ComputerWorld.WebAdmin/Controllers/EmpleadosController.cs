using ComputerWorld.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerWorld.WebAdmin.Controllers
{
    public class EmpleadosController : Controller
    {
        EmpleadosBL _EmpleadosBL;

        public EmpleadosController()
        {
            _EmpleadosBL = new EmpleadosBL();
        }

        // GET: Empleados
        public ActionResult Index()
        {
            var listadeEmpleados = _EmpleadosBL.ObtenerEmpleados();

            return View(listadeEmpleados);
        }

        public ActionResult Crear()
        {
            var nuevoEmpleado = new Empleado();

            return View(nuevoEmpleado);
        }

        [HttpPost]
        public ActionResult Crear(Empleado Empleado)
        {
            if (ModelState.IsValid)
            {
                _EmpleadosBL.GuardarEmpleado(Empleado);

                return RedirectToAction("Index");
            }

            return View(Empleado);
        }

        public ActionResult Editar(int id)
        {
            var Empleado = _EmpleadosBL.ObtenerEmpleado(id);

            return View(Empleado);
        }

        [HttpPost]
        public ActionResult Editar(Empleado Empleado)
        {
            if (ModelState.IsValid)
            {
                _EmpleadosBL.GuardarEmpleado(Empleado);

                return RedirectToAction("Index");
            }

            return View(Empleado);
        }

        public ActionResult Detalle(int id)
        {
            var Empleado = _EmpleadosBL.ObtenerEmpleado(id);

            return View(Empleado);
        }

        public ActionResult Eliminar(int id)
        {
            var Empleado = _EmpleadosBL.ObtenerEmpleado(id);

            return View(Empleado);
        }

        [HttpPost]
        public ActionResult Eliminar(Empleado Empleado)
        {
            _EmpleadosBL.EliminarEmpleado(Empleado.Id);

            return RedirectToAction("Index");
        }
    }
}