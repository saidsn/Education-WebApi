using ServiceLayer.DTOs.Header;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IHeaderService
    {
        Task<List<HeaderDto>> GetAllAsync();
        Task<HeaderDto> GetAsync(int id);
        Task CreateAsync(HeaderCreateDto headerCreateDto);
    }
}
