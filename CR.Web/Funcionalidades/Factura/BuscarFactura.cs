using CR.Web.Funcionalidades.Factura.Parametros;
using System.Collections.Generic;

namespace CR.Web.Funcionalidades.Factura
{
    public class BuscarFactura
    {
        public string Filtro { get; set; }
        public IEnumerable<FacturaViewModel> oIEnumFacturaViewModel { get; set; }

        public BuscarFactura()
        {
            oIEnumFacturaViewModel = new List<FacturaViewModel>();
        }
    }
}