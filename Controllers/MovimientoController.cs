using Microsoft.AspNetCore.Mvc;
using MTG.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MTG.DTO;
using MTG.Models;
using Microsoft.EntityFrameworkCore;

namespace MTG.Controllers
{
    public class MovimientoController : Controller
    {
        private readonly dBaseContext _context;

        public MovimientoController(dBaseContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var depositos = _context.deposito.ToList();
            var productos = _context.productos.ToList();
            var movimientos = _context.movimiento.ToList();

            var DTO = new MoveDTO();
            DTO._Depositos = depositos;
            DTO._Movimiento = movimientos;
            DTO._Productos = productos;
            return View(DTO);
        }

        public async Task<IActionResult> Create()
        {
            var depositos = _context.deposito.ToList();
            var productos = _context.productos.ToList();
            var movimientos = _context.movimiento.ToList();

            var DTO = new MoveDTO();
            DTO._Depositos = depositos;
            DTO._Movimiento = movimientos;
            DTO._Productos = productos;
            return View(DTO);
        }

        public async Task<IActionResult> JustCreate(Movimiento _movi)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(_movi);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException /* ex */)
            {

                ModelState.AddModelError("", "No se puede guardar cambios. " +
                    "pruebe de nuevo, si su problema persiste " +
                    "llame al administrador del sistema.");
            }
            return Redirect("/Home/Index");
        }

    }







}
