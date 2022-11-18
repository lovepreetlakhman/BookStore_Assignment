using TopansBooks.DataAccess.Repository.IRepository;
using TopansBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TopansBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
