using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MTG.Models
{
    public class Stock
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int StockId { get; set; }
        public int DepositoId { get; set; }
        public int ProductosId { get; set; }
        public DateTime fecha_hora { get; set; }
        public int Cantidad { get; set; }

        
        public Deposito deposito { get; set; }
        public Productos productos { get; set; }
        
    }
}
