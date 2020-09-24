﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cookbook.BL.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T obj);
        void Update(T obj);
        void Delete(int id);
        void Save();
    }
}
