﻿using Bloggerweb.Data;
using System;
using System.Collections.Generic;

namespace Bloggerweb.Repo
{
    public interface IRepository<T> where T : BaseEntity  
    {
        IEnumerable<T> GetAll();
        T Get(long id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
