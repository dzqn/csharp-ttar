﻿using System;
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

        public Category GetSingleCategory(int id)
        {
            return categoryDal.Get(x => x.Id == id);
        }

        public Category AddCategory(Category category)
        {
           return  categoryDal.Add(category);
        } 

        public bool DeleteCategory(Category category)
        {
            try
            {
                var currentCategory = categoryDal.Get(x => x.Id == category.Id);
                if (currentCategory != null)
                {
                    categoryDal.Delete(category);
                    return true;

                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Category UpdateCategory(Category category)
        {
           return categoryDal.Update(category);
        }
    }
}
