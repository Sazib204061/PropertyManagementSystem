using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagementSystem.Domain.Common;

namespace ProjectManagementSystem.Domain.Entities
{
    public class Image : BaseEntity
    {
        public int ImageId { get; set; }
        public string Path { get; set; } = string.Empty;
        public int PropertyDetailsId { get; set; }
    }
}
