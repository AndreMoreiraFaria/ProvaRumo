using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaGarcom.Controllers
{
    public class CopaController : Controller
    {

        UnitOfWork.UnitOfWorkApp _uow;
        public CopaController()
        {
            _uow = new UnitOfWork.UnitOfWorkApp();
        }

        // GET: Copa
        public ActionResult Index()
        {
            return View(_uow.PedidoRepository.FindAll());
        }

        // GET: Copa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Copa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Copa/Create
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

        // GET: Copa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Copa/Edit/5
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

        // GET: Copa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Copa/Delete/5
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
