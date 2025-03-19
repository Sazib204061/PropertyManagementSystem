using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectManagementSystem.Application.PropertyDetails
{
    public class PropertyDetailsVM
    {
        public int PropertyDetailsId { get; set; }
        public int PropertyId { get; set; }
        public int TotalRooms { get; set; }
        public int Size { get; set; }
        
    }
}
