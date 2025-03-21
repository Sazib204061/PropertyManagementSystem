namespace ProjectManagementSystem.Application.Properties
{
    public interface IPropertyService
    {
        Task<IEnumerable<PropertyVM>> GetAllPropertiesAsync();
        Task<PropertyVM> GetPropertyByIdAsync(int id);
        Task AddPropertyAsync(PropertyVM property);
        Task UpdatePropertyAsync(int id, PropertyVM property);
        Task DeletePropertyAsync(int id);

    }
}
