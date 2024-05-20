using Asp.NetIntro_MVC.Models;

namespace Asp.NetIntro_MVC.Services.Interface
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);

    }
}
