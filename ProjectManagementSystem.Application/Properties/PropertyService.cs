using AutoMapper;
using ProjectManagementSystem.Application.Repository;
using ProjectManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Application.Properties
{
    public class PropertyService : IPropertyService
    {
        private readonly IBaseRepository<Property> propertyRepository;
        private readonly IMapper _mapper;

        public PropertyService(IBaseRepository<Property> propertyRepository,IMapper mapper)
        {
            this.propertyRepository = propertyRepository;
            _mapper = mapper;
        }

        protected async Task SaveChangesAsync()
        {
            await propertyRepository.SaveChangesAsync();
        }


        public async Task AddPropertyAsync(PropertyVM property)
        {
            var addproperty = _mapper.Map<Property>(property);
            await propertyRepository.AddAsync(addproperty);

        }

        public async Task DeletePropertyAsync(int id, PropertyVM property)
        {
            await propertyRepository.DeleteAsync(id);
            await SaveChangesAsync();
        }

        public Task<IList<PropertyVM>> GetAllPropertysAsync()
        {
            throw new NotImplementedException();
        }

        public Task GetPropertyByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePropertyAsync(int Id, PropertyVM property)
        {
            throw new NotImplementedException();
        }

        public Task<IList<PropertyVM>> GetAllPropertiesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task DeletePropertyAsync(int id)
        {
            await propertyRepository.DeleteAsync(id); 
        }
    }
}
