using System;
using System.Collections.Generic;

namespace Domain
{
    public class Driver
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
        public ICollection<Payed> Payeds { get; set; }
        public ICollection<NumberPhone> Phones { get; set; }
    }
}