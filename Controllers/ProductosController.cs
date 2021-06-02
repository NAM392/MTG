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






        /*public async Task<IActionResult> Edit(int id)
        {
            var professors = _context.productos.ToList();
            var obj = _context.productos.Include(c => c.detalle).Include(c => c.sub_descripcion).Include(c => c.cantidad).ToList().Where(a => a.ProductosId.Equals(id)).FirstOrDefault();
            //Professor_Course_DTO PF = new Professor_Course_DTO();
            //PF.Course_Complete = obj;
            //PF.Professors = professors;
            //if (obj != null) return View(PF);
            //else return Redirect("/Home/Index");
            return  ;
        }
        */











    }
}
