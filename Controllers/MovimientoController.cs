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
            var usuarios = _context.login.ToList();

            var DTO = new NewMoveDTO();
            DTO._Depositos = depositos;
            DTO._Productos = productos;
            DTO._Usuarios = usuarios;
            DTO.UnMovimiento = new Movimiento();

            return View(DTO);
        }

        public async Task<IActionResult> JustCreate(NewMoveDTO _movi)
        {
            //hora actual
            _movi.UnMovimiento.fecha_hora = DateTime.Now;

            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(_movi.UnMovimiento);
                    await _context.SaveChangesAsync();
                    
                }
            }
            catch (DbUpdateException /* ex */)
            {

                ModelState.AddModelError("", "No se puede guardar cambios. " +
                    "pruebe de nuevo, si su problema persiste " +
                    "llame al administrador del sistema.");
            }

            var stock = _context.stock.ToList();
            int flag = 0;
            //recorro el stock
            foreach (var st in stock)
            {       //si estoy en un deposito
                if (st.DepositoId == _movi.UnMovimiento.Hasta_depo)
                {
                    //si ya tengo el producto
                    if (st.ProductosId == _movi.UnMovimiento.ProductosId)
                    {
                        //agrego la cantidad de producto
                        flag = 0;
                        st.Cantidad = st.Cantidad + _movi.UnMovimiento.Cantidad;
                        return Redirect("/Home/Index");
                    }
                    else
                    {
                        //si no tengo el producto en el deposito
                        flag = 1;
                    }

                }
            }
            if(flag == 1)
            {
                //Agrego el producto al deposito
                var NuevoStock = new Stock();
                NuevoStock.DepositoId = _movi.UnMovimiento.Hasta_depo;
                NuevoStock.Cantidad = _movi.UnMovimiento.Cantidad;
                NuevoStock.ProductosId = _movi.UnMovimiento.ProductosId;
                NuevoStock.fecha_hora = DateTime.Now;
                //resto el viejo stock
                foreach(var stc in stock)
                {
                    if(stc.DepositoId == _movi.UnMovimiento.Desde_depo)
                    {
                        stc.Cantidad = stc.Cantidad - _movi.UnMovimiento.Cantidad;
                    }
                }
                try
                {
                    if (ModelState.IsValid)
                    {
                        _context.Add(NuevoStock);
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
            return Redirect("/Home/Index");
        }

    }
}

