using System;
using System.Collections.Generic;

namespace Domain
{
    public class AZS
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public long Number { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Guid NetAZSId { get; set; }
        public NetAZS NetAzs { get; set; }
        public ICollection<Payed> Payeds { get; set; }
    }
}