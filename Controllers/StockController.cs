using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MTG.Models;
using MTG.Data;
using MTG.DTO;
using Microsoft.EntityFrameworkCore;


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

        public async Task<IActionResult> Create()
        {
            var depositos = _context.deposito.ToList();
            var productos = _context.productos.ToList();
            
            var DTO = new NewStockDTO();
            DTO._Depositos = depositos;
            DTO._Productos = productos;            
            DTO.UnStock = new Stock();

            return View(DTO);
        }

        public async Task<IActionResult> JustCreate(NewStockDTO _stc)
        {
            //hora actual
            _stc.UnStock.fecha_hora = DateTime.Now;

            var stock = _context.stock.ToList();
            int flag = 0;
            //recorro el stock
            foreach (var st in stock)
            {       //si estoy en un deposito
                if (st.DepositoId == _stc.UnStock.DepositoId)
                {
                    //si ya tengo el producto
                    if (st.ProductosId == _stc.UnStock.ProductosId)
                    {
                        //agrego la cantidad de producto
                        flag = 0;
                        st.Cantidad = st.Cantidad + _stc.UnStock.Cantidad;
                        return Redirect("/Home/Index");
                    }
                    else
                    {
                        //si no tengo el producto en el deposito
                        flag = 1;
                    }

                }
            }
            if (flag == 1)
            {
                
                try
                {
                    
                    if (ModelState.IsValid)
                    {
                        _context.Add(_stc.UnStock);
                        await _context.SaveChangesAsync();
                        _context.Entry(stock).State = EntityState.Detached;
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
