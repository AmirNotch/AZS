using System;
using System.Collections;
using System.Collections.Generic;

namespace Domain
{
    public class NetAZS
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<AZS> AZSES { get; set; }
    }
}