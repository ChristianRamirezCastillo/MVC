namespace CR.Modelo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FacturaContexto : DbContext
    {
        public FacturaContexto()
            : base("name=Conexion")
        {
        }

        public virtual DbSet<Factura> Factura { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Factura>()
                .Property(e => e.RazonSocial)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.Glosa)
                .IsUnicode(false);
        }
    }
}
