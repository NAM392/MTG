using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MTG.Models
{
    public class Productos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int ProductosId { get; set; }
        public string detalle { get; set; }      
        public string sub_descripcion { get; set; }
        public int cantidad { get; set; }        

    }
}
