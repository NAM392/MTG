using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MTG.Models;
using MTG.Data;
using MTG.DTO;

namespace MTG.Controllers
{
    public class StockController : Controller
    {
        private readonly dBaseContext _context;

        public StockController(dBaseContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var depositos = _context.deposito.ToList();
            var productos = _context.productos.ToList();
            var disponibles = _context.stock.ToList();

            var DTO = new StockDTO();
            DTO._Depositos = depositos;
            DTO._Stock = disponibles;
            DTO._Productos = productos;
            return View(DTO);
        }








    }
}
