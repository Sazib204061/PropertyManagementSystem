using ProjectManagementSystem.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Application.Cities
{
    public class CityService : ICityService
    {
        private readonly IBaseRepository<CityVM> _cityRepository;

        public CityService(IBaseRepository<CityVM> cityRepository)
        {
            _cityRepository = cityRepository;
        }
        public Task AddCityAsync(CityVM city)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCityAsync(int id)
        {
            throw new NotImplementedException();
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
