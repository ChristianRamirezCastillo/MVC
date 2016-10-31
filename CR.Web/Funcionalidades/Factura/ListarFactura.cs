using CR.Modelo;
using CR.Repositorio.Impl;
using CR.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CR.Web.Funcionalidades.Factura
{
    public class ListarFactura : IDisposable
    {
        private FacturaRepositorio oFacturaRepositorio;
        
        public ListarFactura()
        {
            oFacturaRepositorio = new FacturaRepositorio(new FacturaContexto());
        }

        public IEnumerable<FacturaModels> Ejecutar(string sfiltro)
        {
            var consulta = oFacturaRepositorio.Facturas.TrerTodos();

            if (!string.IsNullOrEmpty(sfiltro))
            {

            }

            return consulta.Select(e => new FacturaModels()
                    {
                        Codigo = e.Codigo,
                        RUC = e.RUC,
                        RazonSocial = e.RazonSocial,
                        Fecha = e.Fecha,
                        Glosa = e.Glosa,
                        FechaVencimiento = e.FechaVencimiento,
                        SubTotal = e.SubTotal,
                        IGV = e.IGV,
                        Total = e.Total
                    }).ToList();
        }


        public void Dispose()
        {
            oFacturaRepositorio.Dispose();
        }
    }
}