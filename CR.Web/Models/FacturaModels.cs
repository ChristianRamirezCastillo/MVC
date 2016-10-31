using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CR.Web.Models
{
    public class FacturaModels
    {
        public int Codigo { get; set; }
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