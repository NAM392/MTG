using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MTG.Models;

namespace MTG.Data
{
    public class DbInitializer
    {

        public static void Initialize(dBaseContext context)
        {
            context.Database.EnsureCreated();

            if (context.productos.Any())
            {
                return;   // DB has been seeded
            }
            
            var user = new Login[]
                     {
                       new Login{ LoginId = 1, usuario="Nicolas",password="NNN"},
                       new Login{ LoginId = 2, usuario="Waldo",password="WWW" },
                      };

            foreach (Login l in user)
            {
                context.login.Add(l);
            }
            context.SaveChanges();
            
            var productos = new Productos[]
            {
                    new Productos{ProductosId= 12,detalle="Zapatillas",sub_descripcion="Explorer",cantidad=1234},
                    new Productos{ProductosId= 22,detalle="Guantes",sub_descripcion="Spike",cantidad=4321},
                    new Productos{ProductosId= 32,detalle="Carpa",sub_descripcion="Praia",cantidad=5432},
                    new Productos{ProductosId= 42,detalle="Campera",sub_descripcion="Conor",cantidad=2345},
                    new Productos{ProductosId= 52,detalle="Mochila",sub_descripcion="Cyclone",cantidad=6667},
                   
            };
            foreach (Productos s in productos)
            {
                context.productos.Add(s);
            }
            context.SaveChanges();

            var deposito = new Deposito[]
            {
                        new Deposito{DepositoId = 23,Nombre="Moron"},
                        new Deposito{DepositoId = 88,Nombre="Ushuaia"}

            };

            foreach (Deposito d in deposito)
            {
                context.deposito.Add(d);
            }
            context.SaveChanges();



            var movimiento = new Movimiento[]
                {
                    new Movimiento{ProductosId= 32, Desde_depo = 23 , Hasta_depo = 88 , fecha_hora = DateTime.Now , Id_realizo =1 ,Cantidad = 5432  },
                    new Movimiento{ProductosId = 42,Desde_depo = 23, Hasta_depo = 88, fecha_hora = DateTime.Now , Id_realizo =2, Cantidad = 2345  },
                    new Movimiento{ProductosId = 52 , Desde_depo = 88, Hasta_depo = 23, fecha_hora = DateTime.Now , Id_realizo =1, Cantidad = 6667 },
                };

            foreach (Movimiento e in movimiento)
            {
                context.movimiento.Add(e);
            }
            context.SaveChanges();
            
            
            var stock = new Stock[]
             {
                    new Stock{StockId = 1, DepositoId=23,ProductosId=12,fecha_hora = DateTime.Now, Cantidad = 1234 },
                    new Stock{StockId = 2,DepositoId=88,ProductosId=22,fecha_hora = DateTime.Now, Cantidad = 4321  },
                    new Stock{StockId = 3,DepositoId=23,ProductosId=52,fecha_hora = DateTime.Now, Cantidad = 6667 },
                    new Stock{StockId = 4,DepositoId=88,ProductosId=32,fecha_hora = DateTime.Now, Cantidad = 5432},
                    new Stock{StockId = 5,DepositoId=88,ProductosId=42,fecha_hora = DateTime.Now, Cantidad = 2345 },

            };
            foreach (Stock c in stock)
            {
                context.stock.Add(c);
            }
            context.SaveChanges();
              


        }
    }
}
