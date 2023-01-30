using API.DDD.Core.Interfaces.Repositorys;
using Domain.Services;
using System;
using System.Collections.Generic;

namespace API.DDD.Infrastructure.Data.Repositorys
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        private readonly IBaseRepository<T> _repository;

        public BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        public void Add(T obj)
        {
            _repository.Add(obj);
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public void Remove(T obj)
        {
            _repository.Remove(obj);
        }

        public void Update(T obj)
        {
            _repository.Update(obj);
        }
    }
}
