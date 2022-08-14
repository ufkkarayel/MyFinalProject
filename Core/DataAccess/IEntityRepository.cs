using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // core katmanı diğer katmanları referans almaz.
    // generic constraint
    // class ile T sadece referans tip olabilir kısıtı verilir. 
    // IEntity: IEntity olabilir ya da IEntity implemente eden nesne olabilir. 
    // new(): new'lenebilir olmalı. IEntity newlenemeyeceği için IEntity verilemez T parametresi yerine. 
     public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T Get(Expression<Func<T,bool>>filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
