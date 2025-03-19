using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ProjectManagementSystem.Application.Owner;
using ProjectManagementSystem.Application.Repository;

namespace ProjectManagementSystem.Application.City
{
    public class CityService : ICityService
    {
        private readonly IBaseRepository<CityVM> _cityRepository;
        private readonly IMapper _mapper;

        public CityService(IBaseRepository<CityVM> cityRepository, IMapper mapper)
        {
            _cityRepository = cityRepository;
            _mapper = mapper;
        }


        public async Task AddCityAsync(CityVM city)
        {
           var cityToCreate = _mapper.Map<CityVM>(city);
            await _cityRepository.AddAsync(cityToCreate);


        }

        public async Task DeleteCityAsync(int id)
        {
            var existingCity = await _cityRepository.GetByIdAsync(id);
            if (existingCity == null)
            {
                throw new KeyNotFoundException($"City with ID {id} not found.");
            }
            await _cityRepository.DeleteAsync(id);
        }

        public async Task<IList<CityVM>> GetAllCitiesAsync()
        {
            var cities = await _cityRepository.GetAllAsync();
            return _mapper.Map<IList<CityVM>>(cities);
        }

        public async Task<CityVM> GetCityByIdAsync(int id)
        {
            var city = await _cityRepository.GetByIdAsync(id);
            return _mapper.Map<CityVM>(city);
        }

        public async Task<CityVM> GetCityByNameAsync(string Name)
        {
            var cities = await _cityRepository.GetAllAsync();
            var city = cities.FirstOrDefault(c => c.Name == Name);

            if (city == null)
            {
                throw new KeyNotFoundException($"City with name '{Name}' not found.");
            }

            return _mapper.Map<CityVM>(city);
        }



        public async Task UpdateCityAsync(int Id, CityVM city)
        {
            var existingCity = await _cityRepository.GetByIdAsync(Id);
            if (existingCity == null)
            {
                throw new KeyNotFoundException($"City with ID {Id} not found.");
            }
            _mapper.Map(city, existingCity);
            await _cityRepository.UpdateAsync(existingCity);
        }
    }
}
