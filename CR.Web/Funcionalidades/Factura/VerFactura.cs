using CR.Modelo;
using CR.Repositorio.Impl;
using CR.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CR.Web.Funcionalidades.Factura
{
    public class VerFactura : IDisposable
    {
        private FacturaRepositorio oFacturaRepositorio;

        public VerFactura()
        {
            oFacturaRepositorio = new FacturaRepositorio(new FacturaContexto());
        }

        public FacturaModels Ejecutar(int id)
        {
            var consulta = oFacturaRepositorio.Facturas.TraerUno(
                    x => x.Codigo == id
                );

            FacturaModels oFacturaModels = new FacturaModels()
            {
                Codigo = consulta.Codigo,
                RUC = consulta.RUC,
                RazonSocial = consulta.RazonSocial,
                Fecha = consulta.Fecha,
                Glosa = consulta.Glosa,
                FechaVencimiento = consulta.FechaVencimiento,
                SubTotal = consulta.SubTotal,
                IGV = consulta.IGV,
                Total = consulta.Total
            };

            return oFacturaModels;
        }

        public void Dispose()
        {
            oFacturaRepositorio.Dispose();
        }
    }
}