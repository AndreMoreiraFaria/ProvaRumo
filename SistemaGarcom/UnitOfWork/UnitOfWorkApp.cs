using SistemaGarcom.Data;
using SistemaGarcom.Models;
using SistemaGarcom.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SistemaGarcom.UnitOfWork
{
    public class UnitOfWorkApp : DbContext
    {

        ContextApp context = new ContextApp();
        Repository<Pedido> pedidoRepository;  

        public Repository<Pedido> PedidoRepository
        {
            get
            {
                if (pedidoRepository == null)
                {
                    pedidoRepository = new Repository<Pedido>(context);
                }
                return pedidoRepository;
            }
        }

        public void Commit()
        {
            context.SaveChanges();
        }

    }
}