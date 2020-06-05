using System;
using System.Collections.Generic;
using System.Text;
using Ttar.Business.Abstract;
using Ttar.DAL.Abstract;
using Ttar.Entities.Concrete;

namespace Ttar.Business.Concrete
{
    public class CategoryManager : ICategoryManager
    {
        ICategoryDal categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }
        public List<Category> GetAllCategory()
        {
            return categoryDal.GetList();
        }
    }
}
