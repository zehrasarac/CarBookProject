using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();//listeleme işlemi için
        Task<T> GetByIdAsync(int id); //id ye göre getirme
        Task CreateAsync(T entity); //listeleme
        Task UpdateAsync(T entity);//güncelleme için
        Task RemoveAsync(T entity);
    }
}
