using System;
using System.Collections;
using System.Collections.Generic;

namespace BaseClass
{
    public interface IRepositoryCRUD<T>
    {
        void Insert(T entity);
        void Update(T entity);
        void Save(T entity);
        void Delete(T entity);

        T GetById(int id);
        IEnumerable<T> Get(Func<T, bool> where);
    }
}
