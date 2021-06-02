using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MTG.DTO;
using MTG.Models;
namespace MTG.DTO
{
    public class NewStockDTO
    {
        public List<Deposito> _Depositos { get; set; }
        public List<Productos> _Productos { get; set; }
        public Stock UnStock { get; set; }
        public int cantidad { get; set; }
        public DateTime fecha { get; set; }
    }
}
