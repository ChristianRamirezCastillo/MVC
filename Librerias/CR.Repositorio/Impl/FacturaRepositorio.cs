using CR.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Repositorio.Impl
{
    public class FacturaRepositorio : IDisposable
    {
        private DbContext db;
        private RepositorioGenerico<Factura> _factura;

        public RepositorioGenerico<Factura> Facturas
        {
            get { return _factura; }
        }

        public FacturaRepositorio(DbContext db)
        {
            this.db = db;
            _factura = new RepositorioGenerico<Factura>(db);
        }

        public void Commit()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
