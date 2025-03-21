using AutoMapper;
using ProjectManagementSystem.Application.Repository;
using ProjectManagementSystem.Domain.Entities;

namespace ProjectManagementSystem.Application.PropertyDetails
{
    public class PropertyDetailsService : IPropertyDetailsService

    {
        private readonly IBaseRepository<PropertyDetail> _propertyDetailsRepository;
        private readonly IMapper _mapper;
        public PropertyDetailsService(IBaseRepository<PropertyDetail> propertyDetailsRepository, IMapper mapper)
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
            var propertyDetailsEntity = _mapper.Map<PropertyDetail>(propertyDetails);
            await _propertyDetailsRepository.AddAsync(propertyDetailsEntity);
        }
        public async Task<PropertyDetailsVM> GetPropertyDetailsByIdAsync(int id)
        {
            var propertyDetails = await _propertyDetailsRepository.GetByIdAsync(id);
            if (propertyDetails == null)
            {
                throw new KeyNotFoundException($"PropertyDetails with ID {id} not found.");
            }
            return _mapper.Map<PropertyDetailsVM>(propertyDetails);

        }
        public async Task UpdatePropertyDetailsAsync(int id, PropertyDetailsVM propertyDetails)
        {
            var existingPropertyDetails = await _propertyDetailsRepository.GetByIdAsync(id);
            if (existingPropertyDetails == null)
            {
                throw new KeyNotFoundException($"PropertyDetails with ID {id} not found.");
            }
            _mapper.Map(propertyDetails, existingPropertyDetails);
            await _propertyDetailsRepository.UpdateAsync(existingPropertyDetails);
        }

        public async Task DeletePropertyDetailsAsync(int id)
        {
            var existingPropertyDetails = await _propertyDetailsRepository.GetByIdAsync(id);
            if (existingPropertyDetails == null)
            {
                throw new KeyNotFoundException($"PropertyDetails with ID {id} not found.");
            }
            await _propertyDetailsRepository.DeleteAsync(id);
        }
    }
}
