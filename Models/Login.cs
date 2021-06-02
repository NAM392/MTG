using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MTG.Models
{
    public class Login
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int LoginId { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }

    }
}
