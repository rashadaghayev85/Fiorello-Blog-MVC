using FiorelloMVC.Data;
using FiorelloMVC.Models;
using FiorelloMVC.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FiorelloMVC.Services
{
    public class CategoryService:ICategoryService
    {
        private readonly AppDBContext _context;
        public CategoryService(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
