using System;
using System.Collections.Generic;

namespace API.DDD.Core.Interfaces.Repositorys
{
    public interface IBaseRepository<T> where T : class
    {
        void Add(T obj);
        void Update(T obj);
        void Remove(T obj);
        IEnumerable<T> GetAll();
        T GetById(Guid id);
    }
}
