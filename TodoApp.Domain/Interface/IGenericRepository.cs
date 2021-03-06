﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Entities;

namespace TodoApp.Domain.Interface
{
    public interface IGenericRepository<T>
    {
        Task<QueryResult<T>> GetAll(UserParams userParams);
        Task<List<T>> GetAll();
        Task<T> GetById(Guid id);
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
