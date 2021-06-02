using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MTG.DTO;
using MTG.Models;

namespace MTG.DTO
{
    public class StockDTO
    {
        public List<Deposito> _Depositos { get; set; }
        public List<Productos> _Productos { get; set; }
        public List<Stock> _Stock { get; set; }
        public int cantidad { get; set; }
        public DateTime fecha { get; set; }
    }
}
