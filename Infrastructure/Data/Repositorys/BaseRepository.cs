using API.DDD.Core.Interfaces.Repositorys;
using API.DDD.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace API.DDD.Infrastructure.Data.Repositorys
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly MySqlContext _mySqlContext;

        public BaseRepository(MySqlContext mySqlContext)
        {
            _mySqlContext = mySqlContext;
        }

        public void Add(T obj)
        {
            try
            {
                _mySqlContext.Set<T>().Add(obj);
                _mySqlContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _mySqlContext.Set<T>().ToList();
        }

        public T GetById(Guid id)
        {
            return _mySqlContext.Set<T>().Find(id);
        }

        public void Remove(T obj)
        {
            try
            {
                _mySqlContext.Set<T>().Remove(obj);
                _mySqlContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(T obj)
        {
            try
            {
                _mySqlContext.Entry(obj).State = EntityState.Modified;
                _mySqlContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
