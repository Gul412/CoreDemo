﻿using BusinessLayer.Abstract;
using DAL.Abstract;
using DAL.EntityFramework;
using DAL.Repositories;
using EntityKatmani.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;


        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }


        public Category GetById(int id)
        {
            return _categoryDal.GetbyID(id);
        }
      

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }

        public void TAdd(Category t)
        {
            _categoryDal.Insert(t);

        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);

        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);

        }
    }
}
