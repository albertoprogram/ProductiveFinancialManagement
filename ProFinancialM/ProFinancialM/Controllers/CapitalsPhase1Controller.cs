﻿using ProFinancialM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProFinancialM.Controllers
{
    public class CapitalsPhase1Controller : Controller
    {
        // GET: CapitalsPhase1
        public ActionResult Index()
        {
            return View();
        }

        // GET: CapitalsPhase1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CapitalsPhase1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CapitalsPhase1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CapitalsPhase1 capitalsPhase1)
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

        // GET: CapitalsPhase1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CapitalsPhase1/Edit/5
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

        // GET: CapitalsPhase1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CapitalsPhase1/Delete/5
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