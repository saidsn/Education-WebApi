using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Slider
{
    public class SliderUpdateDto
    {
        public byte[]? Image { get; set; }
        public string? Title { get; set; }
    }
}
