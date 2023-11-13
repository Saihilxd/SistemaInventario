using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IBodegaRepository Bodega { get; }
        Task Save();
    }
}
