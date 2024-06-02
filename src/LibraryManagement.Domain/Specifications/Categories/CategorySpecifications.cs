﻿using LibraryManagement.Domain.Common.Specifications;
using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Domain.Specifications.Categories
{
    public class CategorySpecifications
    {
        public static BaseSpecification<Category> GetAllCategoriesSpec()
        {
            var spec = new BaseSpecification<Category>(x => !x.IsDeleted);
            spec.AddInclude(x => x.Books);
            return spec;
        }

        //Check name exist
        public static BaseSpecification<Category> GetCategoryByNameSpec(string name)
        {
            var spec = new BaseSpecification<Category>(x => x.Name == name);
            return spec;
        }
    }
}