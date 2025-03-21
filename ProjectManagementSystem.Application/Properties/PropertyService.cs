using AutoMapper;
using ProjectManagementSystem.Application.Repository;
using ProjectManagementSystem.Domain.Entities;
namespace ProjectManagementSystem.Application.Properties
{
    //nothing
    public class PropertyService : IPropertyService
    {
        private readonly IBaseRepository<Property> _propertyRepository;
        private readonly IMapper _mapper;

        public PropertyService(IBaseRepository<Property> propertyRepository, IMapper mapper)
        {
            _propertyRepository = propertyRepository;
            _mapper = mapper;
        }

        public async Task AddPropertyAsync(PropertyVM property)
        {
            var addproperty = _mapper.Map<Property>(property);
            await _propertyRepository.AddAsync(addproperty);
        }

        public async Task<PropertyVM> GetPropertyByIdAsync(int id)
        {
            var property = await _propertyRepository.GetByIdAsync(id);
            if (property == null)
            {
                throw new KeyNotFoundException($"Property with Id {id} not found");
            }
            return _mapper.Map<PropertyVM>(property);
        }

        public async Task UpdatePropertyAsync(int id, PropertyVM property)
        {
            var existingProperty = await _propertyRepository.GetByIdAsync(id);
            if (existingProperty == null)
            {
                throw new KeyNotFoundException($"Property with Id {id} not found");
            }
            _mapper.Map(property, existingProperty);
            await _propertyRepository.UpdateAsync(existingProperty);
        }

        public async Task DeletePropertyAsync(int id)
        {
            var existingProperty = await _propertyRepository.GetByIdAsync(id);
            if (existingProperty == null)
            {
                throw new KeyNotFoundException($"Property with Id {id} not found");
            }
            await _propertyRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<PropertyVM>> GetAllPropertiesAsync()
        {
            var properties = await _propertyRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<PropertyVM>>(properties);
        }
    }
}
