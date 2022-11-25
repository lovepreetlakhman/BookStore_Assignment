using System;
using System.Collections.Generic;
using System.Text;
using TopansBooks.Models;

namespace TopansBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
