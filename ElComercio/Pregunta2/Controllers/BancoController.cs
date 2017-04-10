using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Context;

namespace Pregunta2.Controllers
{
    public class BancoController : Controller
    {
        // GET: Banco
        public ActionResult Index()
        {
            List<Banco> Lista = new List<Banco>();
            DA Context = new DA();

            Lista = Context.Bancos;
            return View(Lista);
        }

        // GET: Banco/Details/5
        public ActionResult Details(int id)
        {
            return View("BancoDetail", id);
        }

        // GET: Banco/Create
        public ActionResult Create()
        {
            return View("BancoCreate");
        }

        // POST: Banco/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Banco nuevoBanco = new Banco()
                {
                    Direccion = collection.GetValue("Direccion").RawValue.ToString(),
                    Fecha = DateTime.Parse(collection.GetValue("Fecha").RawValue.ToString()),
                    id = int.Parse(collection.GetValue("id").RawValue.ToString()),
                    Nombre = collection.GetValue("Nombre").RawValue.ToString()
                };

                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: Banco/Edit/5
        public ActionResult Edit(int id)
        {
            return View("BancoEdit");
        }

        // POST: Banco/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: Banco/Delete/5
        public ActionResult Delete(int id)
        {
            return View("Index");
        }

        // POST: Banco/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }
        }
    }
}
