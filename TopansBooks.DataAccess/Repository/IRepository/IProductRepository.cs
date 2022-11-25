using System;
using System.Collections.Generic;
using System.Text;
using TopansBooks.Models;

namespace TopansBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}
