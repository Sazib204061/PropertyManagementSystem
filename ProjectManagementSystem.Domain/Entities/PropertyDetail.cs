using ProjectManagementSystem.Domain.Common;

namespace ProjectManagementSystem.Domain.Entities
{
    public class PropertyDetail : BaseEntity
    {
        public int TotalRooms { get; set; }
        public int Size { get; set; }
        public ICollection<Image> Images { get; set; } = [];
        public Property? Property { get; set; }
        public int PropertyId { get; set; }
    }
}
