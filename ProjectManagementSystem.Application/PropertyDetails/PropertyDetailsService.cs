using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagementSystem.Application.Repository;

namespace ProjectManagementSystem.Application.PropertyDetails
{
    public class PropertyDetailsService : IPropertyDetailsService
    {
        private readonly IBaseRepository<PropertyDetailsVM> _propertyDetailsRepository;
        public PropertyDetailsService(IBaseRepository<PropertyDetailsVM> propertyDetailsRepository)
        {
            _propertyDetailsRepository = propertyDetailsRepository;

        }
        public Task AddPropertyDetailsAsync(PropertyDetailsVM propertyDetails)
        {
            throw new NotImplementedException();
        }
        public Task DeletePropertyDetailsAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<IList<PropertyDetailsVM>> GetAllPropertyDetailsAsync()
        {
            throw new NotImplementedException();
        }
        public Task GetPropertyDetailsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task UpdatePropertyDetailsAsync(int Id, PropertyDetailsVM propertyDetails)
        {
            throw new NotImplementedException();
        }
    }
}
