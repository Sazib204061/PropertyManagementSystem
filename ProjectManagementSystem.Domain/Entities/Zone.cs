using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagementSystem.Domain.Common;

namespace ProjectManagementSystem.Domain.Entities
{
    public class Zone : BaseEntity 
    {
        public int ZoneId { get; set; }
        public string? Name { get; set; } = string.Empty;
        public int CityId { get; set; }
    }
}
