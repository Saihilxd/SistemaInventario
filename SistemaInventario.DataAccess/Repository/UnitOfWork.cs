using SistemaInventario.DataAccess.Data;
using SistemaInventario.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IBodegaRepository Bodega { get; private set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Bodega = new BodegaRepository(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
