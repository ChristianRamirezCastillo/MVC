using CR.Modelo;
using CR.Repositorio.Impl;
using CR.Web.Funcionalidades.Factura.Parametros;
using System;


namespace CR.Web.Funcionalidades.Factura
{
    public class RegistrarFactura : IDisposable
    {
        private FacturaRepositorio oFacturaRepositorio;

        public RegistrarFactura()
        {
            oFacturaRepositorio = new FacturaRepositorio(new FacturaContexto());
        }

        public void Ejecutar(FacturaViewModel oFacturaViewModel)
        {
            Modelo.Factura oFactura = new Modelo.Factura()
            {
                RUC = oFacturaViewModel.RUC,
                RazonSocial = oFacturaViewModel.RazonSocial,
                Fecha = oFacturaViewModel.Fecha,
                Glosa = oFacturaViewModel.Glosa,
                FechaVencimiento = oFacturaViewModel.FechaVencimiento,
                SubTotal = oFacturaViewModel.SubTotal,
                IGV = oFacturaViewModel.IGV,
                Total = oFacturaViewModel.Total
            };

            oFacturaRepositorio.Facturas.Agregar(oFactura);
            oFacturaRepositorio.Commit();
        }

        public void Dispose()
        {
            oFacturaRepositorio.Dispose();
        }
    }
}