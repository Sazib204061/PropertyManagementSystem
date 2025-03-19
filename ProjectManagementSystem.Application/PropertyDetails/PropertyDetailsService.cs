using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ProjectManagementSystem.Application.Repository;

namespace ProjectManagementSystem.Application.PropertyDetails
{
    public class PropertyDetailsService : IPropertyDetailsService

    {
        private readonly IBaseRepository<PropertyDetailsVM> _propertyDetailsRepository;
        private readonly IMapper _mapper;
        public PropertyDetailsService(IBaseRepository<PropertyDetailsVM> propertyDetailsRepository, IMapper mapper)
        {
            _propertyDetailsRepository = propertyDetailsRepository;
            _mapper = mapper;

        }

        public async Task<IList<PropertyDetailsVM>> GetAllPropertyDetailsAsync()
        {
            var propertyDetails = await _propertyDetailsRepository.GetAllAsync();
            return _mapper.Map<IList<PropertyDetailsVM>>(propertyDetails);
        }
        public async Task AddPropertyDetailsAsync(PropertyDetailsVM propertyDetails)
        {
            var propertyDetailsEntity = _mapper.Map<PropertyDetailsVM>(propertyDetails);
            await _propertyDetailsRepository.AddAsync(propertyDetailsEntity);
        }
        public async Task<PropertyDetailsVM> GetPropertyDetailsByIdAsync(int Id)
        {
            var propertyDetails = await _propertyDetailsRepository.GetByIdAsync(Id);
            return _mapper.Map<PropertyDetailsVM>(propertyDetails);

        }
        public async Task UpdatePropertyDetailsAsync(int Id, PropertyDetailsVM propertyDetails)
        {
            var existingPropertyDetails = await _propertyDetailsRepository.GetByIdAsync(Id);
            if (existingPropertyDetails == null)
            {
                throw new Exception("Property Details not found");
            }
            _mapper.Map(propertyDetails, existingPropertyDetails);
            await _propertyDetailsRepository.UpdateAsync(existingPropertyDetails);
        }

        public async Task DeletePropertyDetailsAsync(int Id)
        {
            var existingPropertyDetails = await _propertyDetailsRepository.GetByIdAsync(Id);
            if (existingPropertyDetails == null)
            {
                throw new Exception("Property Details not found");
            }
            await _propertyDetailsRepository.DeleteAsync(Id);


        }
    }
}
