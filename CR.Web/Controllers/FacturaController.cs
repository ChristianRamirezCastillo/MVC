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
        /*
         * Al crear la lista parcial, se programa
         * para que realize desde una vista parcial y liste 
         * las facturas
        */
        public ActionResult Lista(string Filtro)
        {
            using (var oListarFactura = new ListarFactura())
            {
                var result = oListarFactura.Ejecutar(Filtro);
                return View(result);
            }
        }


        #region Registrar Factura
        [HttpGet]
        public ActionResult Registrar()
        {
            return View(new FacturaViewModel());
        }

        [HttpPost]
        public ActionResult Registrar(FacturaViewModel oFacturaViewModel)
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
        #endregion


        #region Vistar Parciales
        public PartialViewResult BuscarPorNombre(string sFiltro)
        {
            using (var oListarFactura = new ListarFactura())
            {
                var result = PartialView("_Buscar", 
                    oListarFactura.Ejecutar(sFiltro));
                return PartialView(result);
            }
        }
        #endregion
    }
}