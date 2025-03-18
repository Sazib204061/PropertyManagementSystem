using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectManagementSystem.Domain.Entities
{
    public class PropertyDetails
    {

        [Key]
        public int PropertyDetailsId { get; set; }
        public string PropertyName { get; set; } = string.Empty;
        public int PropertyId { get; set; }
        public int TotalRoom { get; set; }
        public int Size { get; set; }
        public int ImageId { get; set; }
        public ICollection<Image> Images { get; set; } = [];
    }
}
