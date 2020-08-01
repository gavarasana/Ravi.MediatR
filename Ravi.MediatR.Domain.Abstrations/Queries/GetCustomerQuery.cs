using MediatR;
using Newtonsoft.Json;
using Ravi.MediatR.Domain.Abstrations.Dtos;
using System;
using System.ComponentModel.DataAnnotations;

namespace Ravi.MediatR.Domain.Abstrations.Queries
{
    public class GetCustomerQuery : IRequest<CustomerDto>
    {
        public GetCustomerQuery()
        {  }

        public GetCustomerQuery(Guid customerId)
        {
            CustomerId = customerId;
        }

        [JsonProperty("id")]
        [Required]
        public Guid CustomerId { get; set; }
    }
}
