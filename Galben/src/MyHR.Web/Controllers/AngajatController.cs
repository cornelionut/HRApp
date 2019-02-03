using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyHR.Web.Controllers
{
    public class AngajatController : Controller
    {
        // GET: Angajat
        public ActionResult Index()
        {
            return View();
        }

        // GET: Angajat/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Angajat/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Angajat/Create
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

        // GET: Angajat/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Angajat/Edit/5
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

        // GET: Angajat/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Angajat/Delete/5
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
