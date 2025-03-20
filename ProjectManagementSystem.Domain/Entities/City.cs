using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagementSystem.Domain.Common;

namespace ProjectManagementSystem.Domain.Entities
{
    public class City : BaseEntity
    {
        
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
