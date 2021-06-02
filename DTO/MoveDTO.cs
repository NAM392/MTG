using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MTG.Models;
namespace MTG.DTO
{
    public class MoveDTO
    {
        public List<Deposito> _Depositos { get; set; }
        public List<Productos> _Productos { get; set; }
        public List<Movimiento> _Movimiento { get; set; }
    


    }
}
