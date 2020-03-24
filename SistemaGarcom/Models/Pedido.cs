using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaGarcom.Models
{
    public class Pedido
    {
        public int id { get; set;}
        public string prato { get; set; }
        public  string bebida { get; set; }
        public  int quantidade { get; set; }
        public int mesa { get; set; }
        public string nomeCliente { get; set; }
       
    }
}