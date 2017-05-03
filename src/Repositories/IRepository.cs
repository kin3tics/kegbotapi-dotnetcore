using System.Collections.Generic;

namespace KegbotDotNetCore.API.Repositories
{
    public interface IRepository<T> 
    {
        IEnumerable<T> GetAll();
        T GetById(string id);
        T Create(T item);
        T Update(T item);
        string Delete(T item);
    }
    
}