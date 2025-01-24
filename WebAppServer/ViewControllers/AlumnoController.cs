using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppServer.Models;
using WebAppServer.Services;

namespace WebAppServer.ViewControllers
{
    //Con la ActionResult devolvemos VISTAS (views)
    public class AlumnoController : Controller
    {
        static AlumnoService servicio = new AlumnoService();
        // GET: AlumnoController
        public ActionResult Index() //equivale a GetAll
        {
            return View(servicio.GetAll());
        }

        // GET: AlumnoController/Details/5
        public ActionResult Details(int id)//equivale a GetByID
        {
            return View(servicio.GetByID(id));
        }

        // GET: AlumnoController/Create
        public ActionResult Create()//equivale a Insert
        {
            return View();
        }

        // POST: AlumnoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Alumno a)
        {
            try
            {
                servicio.Insert(a);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AlumnoController/Edit/5
        public ActionResult Edit(int id)//equivale a Update
        {
            return View();
        }

        // POST: AlumnoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AlumnoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AlumnoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
