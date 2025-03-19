using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Application.PropertyDetails
{
    public interface IPropertyDetailsService
    {
        Task<IList<PropertyDetailsVM>> GetAllPropertyDetailsAsync();
        Task GetPropertyDetailsByIdAsync(int id);
        Task AddPropertyDetailsAsync(PropertyDetailsVM propertyDetails);
        Task UpdatePropertyDetailsAsync(int Id, PropertyDetailsVM propertyDetails);
        Task DeletePropertyDetailsAsync(int id);
        
    }
}
