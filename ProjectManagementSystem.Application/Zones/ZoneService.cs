using AutoMapper;
using ProjectManagementSystem.Application.Repository;
using ProjectManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Application.Zones
{
    public class ZoneService : IZoneService
    {
        private readonly IBaseRepository<Zone> _ZoneRepository;
        private readonly IMapper _mapper;

        public ZoneService(IBaseRepository<Zone> ZoneRepository, IMapper mapperl)
        {
            _ZoneRepository = ZoneRepository;
            _mapper = mapperl;
        }


        public async Task AddZoneAsync(ZoneServiceVM zoneService)
        {
            var zoneToCreate = _mapper.Map<Zone>(zoneService);
            await _ZoneRepository.AddAsync(zoneToCreate);
        }

        public async Task DeleteZoneAsync(int id)
        {
            var zone = await _ZoneRepository.GetByIdAsync(id);
            if (zone != null) { throw new KeyNotFoundException("Zone not Found"); }
            await _ZoneRepository.DeleteAsync(id);

        }

        public async Task<IList<ZoneServiceVM>> GetAllZonesAsync()
        {
            var Zones = await _ZoneRepository.GetAllAsync();
            return _mapper.Map<List<ZoneServiceVM>>(Zones);
        }

        public Task<ZoneServiceVM> GetZoneByCityIdAsync(int CityId)
        {
            throw new NotImplementedException();
        }

        public async Task<ZoneServiceVM> GetZoneByIdAsync(int id)
        {
            var zone = await _ZoneRepository.GetByIdAsync(id);
            if (zone == null)
                throw new KeyNotFoundException("Zone not found");

            return _mapper.Map<ZoneServiceVM>(zone);
        }

        public async Task<ZoneServiceVM> GetZoneByNameAsync(string name)
        {
            var zone = (await _ZoneRepository.GetAllAsync())
                .FirstOrDefault(z => z.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (zone == null)
                throw new KeyNotFoundException("Zone not found");

            return _mapper.Map<ZoneServiceVM>(zone);
        }



        public async Task UpdateZoneAsync(int Id, ZoneServiceVM zoneService)
        {
            var zone = await _ZoneRepository.GetByIdAsync(Id);
            if (zone == null)
                throw new KeyNotFoundException("Zone not found");

            _mapper.Map(zone, zoneService);
            await _ZoneRepository.UpdateAsync(zone);
        }


    }
}
