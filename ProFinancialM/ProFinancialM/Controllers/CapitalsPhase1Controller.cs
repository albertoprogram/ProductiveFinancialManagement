using ProFinancialM.Models;
using ProFinancialM.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
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

                if (ModelState.IsValid)
                {
                    CapitalsPhase1Services capitalsPhase1Services = new CapitalsPhase1Services();

                    long idCapPh1FromSQLServer;
                    bool errorFromSQLServer;
                    int errorNumberFromSQLServer;
                    int errorSeverityFromSQLServer;
                    int errorStatusFromSQLServer;
                    string errorProcedureFromSQLServer;
                    int errorLineFromSQLServer;
                    string errorMessageFromSQLServer;
                    string originClass;
                    string originMethod;
                    string inputValues;

                    inputValues = "Amount=" + capitalsPhase1.Amount.ToString() + " " +
                        "Concept=" + capitalsPhase1.Concept;

                    capitalsPhase1Services.InsertCapitalPhase1(capitalsPhase1,
                        out idCapPh1FromSQLServer,
                    out errorFromSQLServer,
                    out errorNumberFromSQLServer,
                    out errorSeverityFromSQLServer,
                    out errorStatusFromSQLServer,
                    out errorProcedureFromSQLServer,
                    out errorLineFromSQLServer,
                    out errorMessageFromSQLServer,
                    out originClass,
                    out originMethod);

                    if (errorFromSQLServer == true)
                    {
                        TempData["ErrorMensaje"] = "Error recibido de SQL";

                        ExceptionHandling exceptionHandling = new ExceptionHandling();

                        exceptionHandling.HandleSQLException(
                            errorNumberFromSQLServer,
                            errorSeverityFromSQLServer,
                            errorStatusFromSQLServer,
                            errorProcedureFromSQLServer,
                            errorLineFromSQLServer,
                            errorMessageFromSQLServer,
                            originClass,
                            originMethod,
                            inputValues);
                    }
                    else
                    {
                        TempData["Exito"] = "Registro insertado con éxito";
                    }

                }

                //return RedirectToAction("Index");
                //return RedirectToAction("Create");
            }

            catch (SqlException ex)
            {
                if (ex.InnerException?.InnerException is SqlException exSql &&
                    exSql.Number == 2601)
                {
                    TempData["ErrorMensaje"] = "El Producto " + "'" + capitalsPhase1.Amount + "'" + " ya está registrado";
                }

                else if (ex.InnerException?.InnerException is SqlException exSql2 &&
                    exSql2.Number == 208)
                {
                    TempData["ErrorMensaje"] = "La tabla destino es inválida";
                }
                else
                {
                    TempData["ErrorMensaje"] = "Error específico SQL no detectado";
                }
            }
            catch (Exception generalException)
            {

                TempData["ErrorMensaje"] = "Error general";

                //ModelState.AddModelError(string.Empty,
                //   "An error occured - please contact your system administrator.");
            }
            finally
            {

            }

            return View();
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
