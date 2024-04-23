using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meno.Application.DTO
{
    public class BaseDto
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatedByName { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}