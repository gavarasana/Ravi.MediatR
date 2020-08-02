using Ravi.MediatR.Data.Abstractions.Entities;
using System.Threading.Tasks;

namespace Ravi.MediatR.Data.Abstractions.Repositories
{
    public interface ICustomerRepository : IRepository<CustomerEntity>
    {
        Task<bool> EmailExistsAsync(string email);
    }
}
