using DomainLayer.Entities;
using ServiceLayer.DTOs.Title;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ITitleService
    {
        Task<List<TitleDto>> GetAllAsync();
    }
}
