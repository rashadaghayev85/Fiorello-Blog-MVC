﻿using FiorelloMVC.Models;
using FiorelloMVC.ViewModels.Blog;

namespace FiorelloMVC.Services.Interfaces
{
    public interface IBlogService
    {
        Task<IEnumerable<BlogVM>> GetAllAsync(int ?take=null);
        Task<Blog> GetByIdAsync(int id);
    }
}
