using System;
using System.Collections.Generic;

namespace Domain
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<Payed> Payeds { get; set; }
        public ICollection<Driver> Drivers { get; set; }
    }
}