using EcommerceMVC.DTOS;

namespace EcommerceMVC.Services.Interfaces
{
    public interface ICategoryService
    {
        //Devuelve un IEnumerable con objetos category , quiere decir que se puede iterar elemento por elemento
        Task<IEnumerable<CategoryReadDto>>GetAllAsync();

        //Devuelve un solo objeto category
        Task<CategoryReadDto> GetByIdAsync(int id);

        Task AddAsync(CategoryCreateDto categoryCreateDto);
        Task UpdateAsync(int id,CategoryCreateDto categoryCreateDto);

        Task DeleteAsync(int id);
    }
}
