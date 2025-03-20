using ProjectManagementSystem.Application.Owners;
using ProjectManagementSystem.Domain.Entities;
using ProjectManagementSystem.Domain.Enums;

namespace ProjectManagementSystem.Application.Properties
{
    public class PropertyVM
    {
        //nothing
        public string? Name { get; set; }
        public Zone? Zone { get; set; }
        public OwnerVM? Owner { get; set; }
        public PropertyStatus Status { get; set; }
        public string? Type { get; set; }
    }
}
