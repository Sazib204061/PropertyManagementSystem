using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagementSystem.Application.Repository;

namespace ProjectManagementSystem.Application.City
{
    public class CityService : ICityService
    {
        private readonly IBaseRepository<CityVM> _cityRepository;

        public CityService(IBaseRepository<CityVM> cityRepository)
        {
            _cityRepository = cityRepository;
        }
        public async Task AddCityAsync(CityVM city)
        {
           await _cityRepository.AddAsync(city);
           await _cityRepository.DeleteAsync(city)

        }

        public async Task DeleteCityAsync(int id)
        {
           await _cityRepository.DeleteAsync(id);
        }

        public Task<IList<CityVM>> GetAllCitiesAsync()
        {
            throw new NotImplementedException();
        }

        public Task GetCityByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CityVM> GetCityByNameAsync(string Name)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCityAsync(int Id, CityVM city)
        {
            throw new NotImplementedException();
        }
    }
}
