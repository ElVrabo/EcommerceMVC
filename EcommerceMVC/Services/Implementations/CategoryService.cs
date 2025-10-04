using EcommerceMVC.Data;
using EcommerceMVC.DTOS;
using EcommerceMVC.Models;
using EcommerceMVC.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EcommerceMVC.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        //se inyecta el contexto, para que este servicio pueda interactuar con la base de datos
        private readonly AppDbContext _context;

        public CategoryService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<CategoryReadDto>> GetAllAsync()
        {
            //Se hace un mapeo
            var categories = await _context.Categories
                .Where(c=>!c.IsDeleted)
                .Select(c => new CategoryReadDto
                {
                    Id= c.Id,
                    Name= c.Name,
                    Active= c.Active,
                    HighSystem= c.HighSystem,
                })
                .ToListAsync();
            return categories;
        }
        public Task<CategoryReadDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task AddAsync(CategoryCreateDto categoryCreateDto)
        {
            
            var catgeory = new Category
            {
                Name = categoryCreateDto.Name
            };
            //Lo agrega al contexto
            _context.Categories.Add(catgeory);
            // Lo guarda en la base de datos
            await _context.SaveChangesAsync();

        }
        public Task UpdateAsync(int id, CategoryCreateDto categoryCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
