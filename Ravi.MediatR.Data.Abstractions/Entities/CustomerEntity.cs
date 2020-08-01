using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ravi.MediatR.Data.Abstractions.Entities
{
    public class CustomerEntity : BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public CustomerEntity(string name, string email, string address, int age, string phoneNumber)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            Address = address;
            Age = age;
            PhoneNumber = phoneNumber;
        }
    }
}
