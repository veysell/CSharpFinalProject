using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //generic constraint
    //class : referans tip
    //new() : newlenebilir olmalı 
    public interface IEntityRepository<T> where T:class,IEntity,new()   
    {
        //filtreler yazmayı sağlayan Delege
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
