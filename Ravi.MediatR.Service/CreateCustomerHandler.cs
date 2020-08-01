using MediatR;
using Ravi.MediatR.Domain.Abstrations.Commands;
using Ravi.MediatR.Domain.Abstrations.Dtos;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ravi.MediatR.Service
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, CustomerDto>
    {
        public Task<CustomerDto> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
