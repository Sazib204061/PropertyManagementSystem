using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagementSystem.Domain.Entities;

namespace ProjectManagementSystem.Application.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        public IQueryable<T> Table { get; }
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task AddAsync(T entity);
        Task DeleteAsync(Appointment appointmentToDelete);
        Task GetByConditionAsync(Func<object, bool> value);
    }
}
