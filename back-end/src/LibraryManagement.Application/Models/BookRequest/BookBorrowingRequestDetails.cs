﻿using LibraryManagement.Domain.Common.Models;
using LibraryManagement.Domain.Entities;

namespace LibraryManagement.Application.Models.BookRequest
{
    public class BookBorrowingRequestDetails : BaseEntity
    {
        public Guid BookBorrowingRequestId { get; set; }

        public DateTime BorrowedDate { get; set; }
        public DateTime? ReturnedDate { get; set; }

        public Guid BookId { get; set; }

        //Navigation property
        public BookBorrowingRequest? BookBorrowingRequest { get; set; }

        public Book Book { get; set; }
    }
}