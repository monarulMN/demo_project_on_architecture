using Architecture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.Domain.Entities
{
    public class Product : IAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    } 
}
