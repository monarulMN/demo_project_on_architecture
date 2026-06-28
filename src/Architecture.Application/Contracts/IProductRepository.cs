using Architecture.Domain.Entities;
using Architecture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.Application.Contracts
{
    public interface IProductRepository : IRepository<Product,  Guid>
    {
    }
}
