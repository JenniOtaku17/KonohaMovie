using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KonohaMovie.Controllers
{
    public class RentaController : Controller
    {
        // GET: Renta
        public ActionResult Index()
        {
            return View();
        }

        // GET: Renta/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Renta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Renta/Create
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

        // GET: Renta/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Renta/Edit/5
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

        // GET: Renta/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Renta/Delete/5
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
