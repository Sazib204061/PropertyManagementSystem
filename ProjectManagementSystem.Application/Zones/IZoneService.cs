using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Application.Zones
{
    public interface IZoneService
    {
         Task<IList<ZoneServiceVM>> GetAllZonesAsync();
        Task<ZoneServiceVM> GetZoneByIdAsync(int id);
        Task AddZoneAsync(ZoneServiceVM zone);
        Task UpdateZoneAsync(int id, ZoneServiceVM zone);
        Task DeleteZoneAsync(int id);
        Task<ZoneServiceVM> GetZoneByNameAsync(string Name);
        Task<ZoneServiceVM> GetZoneByCityIdAsync(int CityId);
         

    }
}
