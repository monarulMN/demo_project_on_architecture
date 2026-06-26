using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.Domain.Interfaces
{
    public interface IAggregateRoot<TKey>
    {
        TKey Id { get; set; }
    }
}
