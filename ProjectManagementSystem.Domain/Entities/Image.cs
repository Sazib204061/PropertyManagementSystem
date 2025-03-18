using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Domain.Entities
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }
        public string Path { get; set; } = string.Empty;
        public string Property { get; set; } = string.Empty;
        public int DetailsId { get; set; }
        public PropertyDetails? PropertiesDetails { get; set; }
    }
}
