using ProjectManagementSystem.Application.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Application.Properties
{
    public interface IPropertyService
    {
        Task<IList<PropertyVM>> GetAllPropertiesAsync();
        Task GetPropertyByIdAsync(int id);
        Task AddPropertyAsync(PropertyVM property);
        Task UpdatePropertyAsync(int Id, PropertyVM property);
        Task DeletePropertyAsync(int id);
        
    }
}
