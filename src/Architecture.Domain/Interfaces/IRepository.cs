using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.Domain.Interfaces
{
    public interface IRepository<TAggregateRoot, TKey>
        where TAggregateRoot : class, IAggregateRoot<TKey>
        where TKey : IComparable
    {
        void Add(TAggregateRoot entity);
        void AddAsync(TAggregateRoot entity);
        void Update(TAggregateRoot entity);
        void UpdateAsync(TAggregateRoot entity);
        void Delete(TAggregateRoot entity);
        void DeleteAsync(TAggregateRoot entity);
    }
}
