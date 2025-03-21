namespace ProjectManagementSystem.Application.Cities
{
    public interface ICityService
    {
        Task<IList<CityVM>> GetAllCitiesAsync();
        Task<CityVM> GetCityByIdAsync(int id);
        Task AddCityAsync(CityVM city);
        Task UpdateCityAsync(int id, CityVM city);
        Task DeleteCityAsync(int id);
        Task<CityVM> GetCityByNameAsync(string Name);
    }
}
