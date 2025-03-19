using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagementSystem.Domain.Common;

namespace ProjectManagementSystem.Domain.Entities
{
    public class Owner
    {
        public string Name { get; set; } = string.Empty;
        public string? ContactNumber { get; set; }
        public string? Email { get; set; }
        public ICollection<Property> Properties { get; set; }

    }
}
