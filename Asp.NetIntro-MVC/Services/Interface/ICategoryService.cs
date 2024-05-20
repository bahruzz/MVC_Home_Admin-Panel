using Asp.NetIntro_MVC.Models;
using Asp.NetIntro_MVC.ViewModels.Categories;

namespace Asp.NetIntro_MVC.Services.Interface
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<IEnumerable<CategoryProductVM>> GetAlWithProductCountAsync();
        Task<Category> GetByIDAsync(int id);
        Task<bool> ExistAsync(string name);
        Task CreateAsync(Category category);
        Task DeleteAsync(Category category);
    }
}
