using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MTG.Models
{
    public class Deposito
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int DepositoId { get; set; }
        public string Nombre { get; set; }
        
    }
}
