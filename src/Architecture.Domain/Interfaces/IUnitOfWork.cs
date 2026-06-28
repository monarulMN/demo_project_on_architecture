using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        void Save();
        Task SaveAsync();
    }
}
