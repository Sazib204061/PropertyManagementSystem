using ProjectManagementSystem.Domain.Entities;
using ProjectManagementSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Application.Properties
{
    public class PropertyVM
    {
        //nothing
        public string? Name { get; set; }
        public Zone? Zone { get; set; }
        public Owner? Owner { get; set; }
        public PropertyStatus Status { get; set; }
        public string? Type { get; set; }
    }
}
