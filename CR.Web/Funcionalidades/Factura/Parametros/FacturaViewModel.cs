using FluentValidation.Attributes;
using System;


namespace CR.Web.Funcionalidades.Factura.Parametros
{
    [Validator(typeof(FacturaViewModelValidator))]    
    public class FacturaViewModel
    {
        public int? RUC { get; set; }
        public string RazonSocial { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public DateTime? Fecha { get; set; }
        public string Glosa { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? IGV { get; set; }
        public decimal? Total { get; set; }
    }
}