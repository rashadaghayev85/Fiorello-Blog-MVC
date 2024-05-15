using FiorelloMVC.Models;

namespace FiorelloMVC.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllAsync();
    }
}
