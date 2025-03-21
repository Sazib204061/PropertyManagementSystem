namespace ProjectManagementSystem.Application.Zones
{
    public interface IZoneService
    {
        Task<IList<ZoneVM>> GetAllZonesAsync();
        Task<ZoneVM> GetZoneByIdAsync(int id);
        Task AddZoneAsync(ZoneVM zone);
        Task UpdateZoneAsync(int id, ZoneVM zone);
        Task DeleteZoneAsync(int id);
    }
}
