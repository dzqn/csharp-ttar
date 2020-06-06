using System;
using System.Collections.Generic;
using System.Text;
using Ttar.Entities.Concrete;

namespace Ttar.Business.Abstract
{
    public interface ICategoryManager
    {
        List<Category> GetAllCategory();
        bool DeleteCategory(Category category);
    }
}
