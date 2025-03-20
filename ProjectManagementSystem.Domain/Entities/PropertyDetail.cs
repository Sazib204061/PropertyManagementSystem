using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagementSystem.Domain.Common;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectManagementSystem.Domain.Entities
{
    public class PropertyDetail : BaseEntity
    {
        
        public int TotalRooms { get; set; }
        public int Size { get; set; }
        public ICollection<Image>? Images { get; set; } = [];
        public int PropertyId { get; set; }
    }
}
