using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MTG.DTO;
using MTG.Models;

namespace MTG.DTO
{
    public class NewMoveDTO
    {
        public List<Deposito> _Depositos { get; set; }
        public List<Productos> _Productos { get; set; }
        public List<Login> _Usuarios { get; set; }
        public Movimiento UnMovimiento{ get; set; }
        public int cantidad { get; set; }
        public DateTime fecha { get; set; }



    }
}

