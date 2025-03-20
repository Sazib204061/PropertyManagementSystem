using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Application.Owners
{
    public interface IOwnerService
    {
        Task<IList<OwnerVM>> GetAllOwnersAsync();
        Task<OwnerVM> GetOwnerByIdAsync(int id);
        Task AddOwnerAsync(OwnerVM owner);
        Task UpdateOwnerAsync(int id, OwnerVM owner);
        Task DeleteOwnerAsync(int id);
        
    }
}
