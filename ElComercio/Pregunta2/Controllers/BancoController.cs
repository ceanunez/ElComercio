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
            return View();
        }

        // GET: Banco/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Banco/Create
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

        // GET: Banco/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
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
                return View();
            }
        }

        // GET: Banco/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
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
                return View();
            }
        }
    }
}
