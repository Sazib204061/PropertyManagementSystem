using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagementSystem.Domain.Entities;

namespace ProjectManagementSystem.Application.City
{
    public interface ICityService
    {
        Task<IList<CityVM>> GetAllCitiesAsync();
        Task<CityVM> GetCityByIdAsync(int id);
        Task AddCityAsync(CityVM city);
        Task UpdateCityAsync(int Id, CityVM city);
        Task DeleteCityAsync(int id);
        Task<CityVM> GetCityByNameAsync(string Name);
    }
}
