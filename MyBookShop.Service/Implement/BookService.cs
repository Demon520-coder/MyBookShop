using MyBookShop.Models;
using MyBookShop.Repository.Interface;
using MyBookShop.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookShop.Service.Implement
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Book GetBook(int bookId)
        {
            return _bookRepository.Find(bookId);
        }
    }
}
