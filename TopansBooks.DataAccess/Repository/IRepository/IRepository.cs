﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace TopansBooks.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);  // Retrieve a category from the database by id
        // List of Categories based on requirements

        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> oderby = null,
            string includeProperties = null    // useful for foreign key references
            );

        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );

        void Add(T entity); // to add an entity 
        void Remove(int id);  // to remove an object or category
        void Remove(T entity); // another way to remove an object 
        void RemoveRange(IEnumerable<T> entity); // removes a complete range of entities
    }
}
