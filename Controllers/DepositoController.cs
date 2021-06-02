using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MTG.Data;
using MTG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTG.Controllers
{
    public class DepositoController : Controller
    {
        private readonly dBaseContext _context;

        public DepositoController(dBaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(_context.deposito.ToList());
        }

        public async Task<IActionResult> Details(int id)
        {

            var obj = _context.deposito.ToList().Where(a => a.DepositoId.Equals(id)).FirstOrDefault();
            if (obj != null) return View(obj);
            else return Redirect("/Home/Index");
        }

        public async Task<IActionResult> Create()
        {
            var deposito = new Deposito();
            if (deposito != null) return View(deposito);
            else return Redirect("/Home/Index");
        }

        public async Task<IActionResult> JustCreate(Deposito _depo)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(_depo);
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

        public async Task<IActionResult> Edit(int id)
        {
            var obj = _context.deposito.ToList().Where(a => a.DepositoId.Equals(id)).FirstOrDefault();
            if (obj != null) return View(obj);
            else return Redirect("/Home/Index");
        }

        public async Task<IActionResult> Update(Deposito _deposito)
        {
            if (_deposito.DepositoId == null)
            {
                return NotFound();
            }
            var DepositoModificable = await _context.deposito.FirstOrDefaultAsync(s => s.DepositoId == _deposito.DepositoId);

            DepositoModificable.DepositoId = _deposito.DepositoId;
            DepositoModificable.Nombre = _deposito.Nombre;
           

            try
            {
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException /* ex */)
            {

                ModelState.AddModelError("", "No se puede guardar cambios. " +
                    "pruebe de nuevo, si su problema persiste " +
                    "llame al administrador del sistema.");
            }

            return View(DepositoModificable);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var deposito = await _context.deposito.FindAsync(id);
            if (deposito == null)
            {
                return RedirectToAction(nameof(Index));
            }

            try
            {
                _context.deposito.Remove(deposito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException /* ex */)
            {

                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }
        }

    }
}
