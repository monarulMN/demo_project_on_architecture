using Architecture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.Application.Contracts
{
    public interface IApplicationUnitOfWork : IUnitOfWork
    {
        public IProductRepository ProductRepository { get; }
    }
}
