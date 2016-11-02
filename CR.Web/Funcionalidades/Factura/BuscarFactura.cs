using CR.Web.Funcionalidades.Factura.Parametros;
using CR.Web.Models;
using System.Collections.Generic;

namespace CR.Web.Funcionalidades.Factura
{
    public class BuscarFactura
    {
        public string Filtro { get; set; }
        public IEnumerable<FacturaModels> Facturas { get; set; }

        public BuscarFactura()
        {
            Facturas = new List<FacturaModels>();
        }
    }
}