﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain.Repository
{
    internal interface IBaseRepository<TEntity> where TEntity : class
    {
        void Save(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        List<TEntity> GetEntities();
        TEntity GetEntity(int Id);
    }
}