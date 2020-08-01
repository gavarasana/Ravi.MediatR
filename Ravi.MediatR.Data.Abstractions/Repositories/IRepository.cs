using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ravi.MediatR.Data.Abstractions.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : ModelBase
    {
        
    }
}
