using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Domain.Entities
{
    public class Zone
    {
        public int ZoneId { get; set; }
        public string ZoneName { get; set; } = string.Empty;
        public int CityId { get; set; }
    }
}
