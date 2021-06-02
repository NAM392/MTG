using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MTG.Models
{
    public class Movimiento
    {
        [Key]
        public int MovimientoId { get; set; }
        public int ProductosId { get; set; }
        public int Desde_depo { get; set; }
        public int Hasta_depo { get; set; }
        public DateTime fecha_hora { get; set; }
        public int Id_realizo { get; set; }

        public Productos productos { get; set; }




    }
}
