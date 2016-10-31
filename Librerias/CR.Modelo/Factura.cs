namespace CR.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Factura")]
    public partial class Factura
    {
        [Key]
        public int Codigo { get; set; }

        public int? RUC { get; set; }

        [StringLength(100)]
        public string RazonSocial { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaVencimiento { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }

        [StringLength(50)]
        public string Glosa { get; set; }

        public decimal? SubTotal { get; set; }

        public decimal? IGV { get; set; }

        public decimal? Total { get; set; }
    }
}
