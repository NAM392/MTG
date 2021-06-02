using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MTG.Data;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MTG.Models;
using System.Web;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
//using MTG.DTO;

namespace MTG.Controllers
{
        public class LoginController : Controller
        {
            private readonly dBaseContext _context;
            public const string sessionkeyname = "usuario";
            public const string sessionpass = "password";


            public LoginController(dBaseContext context)
            {
                _context = context;
            }
            public ActionResult Login()
            {
                return View();
            }


            public ActionResult Logger(Login Log_)
            {

                try
                {
                     var obj = _context.login.ToList().Where(a => a.usuario.Equals(Log_.usuario) && a.password.Equals(Log_.password)).FirstOrDefault();
                        if (obj != null)
                        {
                            HttpContext.Session.SetString(sessionkeyname, (obj.usuario));
                            HttpContext.Session.SetString(sessionpass, obj.password);
                            return Redirect("/Home/Index");
                        }
                   
                }
                catch (Exception e)
                {

                    throw e;
                }

                return Redirect("/Login");
            }

            public async Task<IActionResult> Index()
            {
                return View();
            }

        }
  }


