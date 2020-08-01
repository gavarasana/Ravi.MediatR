using Ravi.MediatR.Domain.Abstrations.Dtos;
using MediatR;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System;

namespace Ravi.MediatR.Domain.Abstrations.Commands
{
    public class CreateCustomerCommand : IRequest<CustomerDto>
    {
        public CreateCustomerCommand(){ }
        public CreateCustomerCommand(string name, string email, string address, 
            TimeSpan age, string phoneNumber )
        {
            Name = name;
            Email = email;
            Address = address;
            Age = age;
            PhoneNumber = phoneNumber;
        }

        [JsonProperty("name")]
        [Required]
        [MaxLength(255)]
        public string Name { get; }
        [JsonProperty("email")]
        [Required]
        [MaxLength(255)]
        [EmailAddress]
        public string Email { get; }
        [JsonProperty("address")]
        [Required]
        [MaxLength(255)]
        public string Address { get; }
        [JsonProperty("age")]
        [Required]
        public TimeSpan Age { get; }
        [JsonProperty("phone_number")]
        [Required]
        [Phone]
        public string PhoneNumber { get; }
    }
}
