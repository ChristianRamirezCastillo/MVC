using CR.Web.Funcionalidades.Factura;
using CR.Web.Funcionalidades.Factura.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CR.Web.Controllers
{
    public class FacturaController : Controller
    {

        public ActionResult Lista()
        {
            using (var oListarFactura = new ListarFactura())
            {
                var result = oListarFactura.Ejecutar();
                return View(result);
            }
        }

        public ActionResult Crear(FacturaViewModel oFacturaViewModel)
        {
            if (!ModelState.IsValid) return View(oFacturaViewModel);
            using (var oRegistrarFactura = new RegistrarFactura())
            {
                try
                {
                    oRegistrarFactura.Ejecutar(oFacturaViewModel);
                    return Redirect("Lista");
                }
                catch (Exception)
                {
                    return View(oFacturaViewModel);
                }
                        
                

            }
        }
    }
}