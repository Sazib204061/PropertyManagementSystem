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
        Task AddPropertyDetailsAsync(PropertyDetailsVM propertyDetails);
        Task<PropertyDetailsVM> GetPropertyDetailsByIdAsync(int Id);
        Task UpdatePropertyDetailsAsync(int Id, PropertyDetailsVM propertyDetails);
        Task DeletePropertyDetailsAsync(int Id);
        
    }
}
