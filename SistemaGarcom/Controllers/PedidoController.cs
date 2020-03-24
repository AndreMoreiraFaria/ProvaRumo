using SistemaGarcom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaGarcom.Controllers
{
    public class PedidoController : Controller
    {

        UnitOfWork.UnitOfWorkApp _uow;
        public PedidoController()
        {
            _uow = new UnitOfWork.UnitOfWorkApp();
        }

        // GET: Pedido
        public ActionResult Index()
        {
            return View(_uow.PedidoRepository.FindAll());
        }

        // GET: Pedido/Details/5
        public ActionResult Details(int id)
        {
            return View(_uow.PedidoRepository.FindById(id));
        }

        // GET: Pedido/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pedido/Create
        [HttpPost]
        public ActionResult Create(Pedido pedido)
        {
            try
            {
                // TODO: Add insert logic here
 
                _uow.PedidoRepository.Add(pedido);
                _uow.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pedido/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_uow.PedidoRepository.FindById(id));
        }

        // POST: Pedido/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Pedido pedido)
        {
            try
            {
                // TODO: Add update logic here
                _uow.PedidoRepository.Edit(pedido);
                _uow.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pedido/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_uow.PedidoRepository.FindById(id));
        }

        // POST: Pedido/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Pedido pedido)
        {
            try
            {
                // TODO: Add delete logic here
                _uow.PedidoRepository.Remove(_uow.PedidoRepository.FindById(id));
                _uow.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
