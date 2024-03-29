﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MTG.Data;
using MTG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTG.Controllers
{
    public class ProductosController : Controller
    {
        private readonly dBaseContext _context;

        public ProductosController(dBaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {            
            return View(_context.productos.ToList());
        }

        public async Task<IActionResult> Details(int id)
        {    
            
            var obj = _context.productos.ToList().Where(a => a.ProductosId.Equals(id)).FirstOrDefault();
            if (obj != null) return View(obj);
            else return Redirect("/Home/Index");
        }

        public async Task<IActionResult> Create()
        {
            var productos = new Productos();
            if (productos != null) return View(productos);
            else return Redirect("/Home/Index");
        }

        public async Task<IActionResult> JustCreate(Productos _producto)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(_producto);
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
            var obj = _context.productos.ToList().Where(a => a.ProductosId.Equals(id)).FirstOrDefault();
            if (obj != null) return View(obj);
            else return Redirect("/Home/Index");
        }

        public async Task<IActionResult> Update(Productos _producto)
        {
            if (_producto.ProductosId == null)
            {
                return NotFound();
            }
            var ProductoModificable = await _context.productos.FirstOrDefaultAsync(s => s.ProductosId == _producto.ProductosId);

            ProductoModificable.detalle = _producto.detalle;
            ProductoModificable.sub_descripcion = _producto.sub_descripcion;
            ProductoModificable.cantidad = _producto.cantidad;

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

            return View(ProductoModificable);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var producto = await _context.productos.FindAsync(id);
            if (producto == null)
            {
                return RedirectToAction(nameof(Index));
            }

            try
            {
                _context.productos.Remove(producto);
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
