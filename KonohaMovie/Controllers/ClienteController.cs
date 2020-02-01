using KonohaMovie.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KonohaMovie.Controllers
{
    public class ClienteController : Controller
    {

        // GET: Cliente
        public ActionResult Index()
        {
            using(KonohaMovieEntities km = new KonohaMovieEntities())
            {
                return View(km.cliente.ToList());
            }

        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            using(KonohaMovieEntities km = new KonohaMovieEntities())
            {
                return View(km.cliente.Where(x => x.id == id).FirstOrDefault());
            }

        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(cliente cliente)
        {
            try
            {
                using (KonohaMovieEntities km = new KonohaMovieEntities())
                {
                    km.cliente.Add(cliente);
                    km.SaveChanges();
                }
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            using (KonohaMovieEntities km = new KonohaMovieEntities())
            {
                return View(km.cliente.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, cliente cliente)
        {
            try
            {
                using (KonohaMovieEntities km = new KonohaMovieEntities())
                {
                    km.Entry(cliente).State = EntityState.Modified;
                    km.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            using(KonohaMovieEntities km = new KonohaMovieEntities())
            {
                return View(km.cliente.Where(x => x.id == id).FirstOrDefault());
            }

        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, cliente cliente)
        {
            try
            {
                using (KonohaMovieEntities km = new KonohaMovieEntities())
                {
                    var removable = km.cliente.Where(x => x.id == id).FirstOrDefault();
                    km.cliente.Remove(removable);
                    km.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
