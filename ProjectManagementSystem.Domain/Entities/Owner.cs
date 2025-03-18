using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Domain.Entities
{
    public class Owner
    {
        public int OwnerId { get; set; }
        public string OwnerName { get; set; } = string.Empty;
        public int ContactNumber { get; set; }
        public string Email { get; set; }
        public ICollection<Property> Property { get; set; }





    }
}
