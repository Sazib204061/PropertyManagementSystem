using AutoMapper;
using ProjectManagementSystem.Application.Repository;
using ProjectManagementSystem.Domain.Entities;

namespace ProjectManagementSystem.Application.Zones
{
    public class ZoneService : IZoneService
    {
        private readonly IBaseRepository<Zone> _zoneRepository;
        private readonly IMapper _mapper;

        public ZoneService(IBaseRepository<Zone> zoneRepository, IMapper mapperl)
        {
            _zoneRepository = zoneRepository;
            _mapper = mapperl;
        }
        public async Task AddZoneAsync(ZoneVM zoneService)
        {
            var zoneToCreate = _mapper.Map<Zone>(zoneService);
            await _zoneRepository.AddAsync(zoneToCreate);
        }

        public async Task DeleteZoneAsync(int id)
        {
            var currZone = await _zoneRepository.GetByIdAsync(id);
            if (currZone == null)
            {
                throw new KeyNotFoundException($"Zone with ID {id} not found.");
            }
            await _zoneRepository.DeleteAsync(id);
        }
        public async Task<IList<ZoneVM>> GetAllZonesAsync()
        {
            var Zones = await _zoneRepository.GetAllAsync();
            return _mapper.Map<List<ZoneVM>>(Zones);
        }
        public async Task<ZoneVM> GetZoneByIdAsync(int id)
        {
            var zone = await _zoneRepository.GetByIdAsync(id);
            if (zone == null)
            {
                throw new KeyNotFoundException($"Zone with ID {id} not found.");
            }
            return _mapper.Map<ZoneVM>(zone);
        }
        public async Task UpdateZoneAsync(int id, ZoneVM zone)
        {
            var currZone = await _zoneRepository.GetByIdAsync(id);

            if (currZone == null)
            {
                throw new KeyNotFoundException($"Zone with ID {id} not found.");
            }
            _mapper.Map(zone, currZone);
            await _zoneRepository.UpdateAsync(currZone);
        }
    }
}
