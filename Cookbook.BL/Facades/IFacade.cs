using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.BL.Facades
{
    public interface IFacade<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T obj);
        void Update(T obj);
        void Delete(T obj);
    }
}
