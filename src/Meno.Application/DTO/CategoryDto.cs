using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meno.Application.DTO
{
    public class CategoryDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}