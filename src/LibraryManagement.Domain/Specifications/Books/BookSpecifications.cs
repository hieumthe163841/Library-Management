﻿using LibraryManagement.Domain.Common.Specifications;
using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Domain.Specifications.Books
{
    public class BookSpecifications
    {
        public static BaseSpecification<Book> GetAllBooksSpec()
        {
            var spec = new BaseSpecification<Book>(x => x.IsDeleted == false);
            spec.AddInclude(x => x.Category);
            return spec;
        }

        public static BaseSpecification<Book> GetBookByTitleSpec(string title)
        {
            var spec = new BaseSpecification<Book>(x => x.Title == title);
            return spec;
        }

        //get book include category
    }
}