﻿using ServiceLayer.DTO_s.Author;

namespace ServiceLayer.Services.Interfaces
{
    public interface IAuthorService
    {
        Task<AuthorDto> GetAsync(int id);
        Task<List<AuthorListDto>> GetAllAsync();
        Task CreateAsync(AuthorCreateDto authorCreateDto);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, AuthorUpdateDto authorUpdateDto);
    }
}