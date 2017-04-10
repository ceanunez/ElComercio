using Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Context;
namespace Pregunta2.Controllers
{
    public class OrdenPagoController : Controller
    {
        // GET: OrdenPago
        public ActionResult Index()
        {
            List<OrdenPago> Lista = new List<OrdenPago>();
            DA Context = new DA();
            Lista = Context.OrdenesPago;
            return View(Lista);
        }

        // GET: OrdenPago/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrdenPago/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrdenPago/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: OrdenPago/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrdenPago/Edit/5
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
                return View();
            }
        }

        // GET: OrdenPago/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrdenPago/Delete/5
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
                return View();
            }
        }
    }
}
