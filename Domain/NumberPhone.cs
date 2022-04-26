using System;

namespace Domain
{
    public class NumberPhone
    {
        public Guid Id { get; set; }
        public long Number { get; set; }
        public Guid DriverId { get; set; }
        public Driver Driver { get; set; }
    }
}