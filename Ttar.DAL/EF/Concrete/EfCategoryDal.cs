using System;
using System.Collections.Generic;
using System.Text;
using Ttar.Core.DAL.EntityFramework;
using Ttar.DAL.Abstract;
using Ttar.Entities.Concrete;

namespace Ttar.DAL.Concrete
{
    public class EfCategoryDal: EfRepository<Category,EfContext> , ICategoryDal
    {
    }
}
