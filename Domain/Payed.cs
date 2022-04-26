using System;

namespace Domain
{
    public class Payed
    {
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
        
        public Guid DriverId { get; set; }
        public Driver Driver { get; set; }

        public Guid AZSId { get; set; }
        public AZS Azs { get; set; }

        public int Money { get; set; }
        
        public int Count { get; set; }
        
        public long DriverPayed { get; set; }
        
        public string AZSApplied { get; set; }
        
    }
}