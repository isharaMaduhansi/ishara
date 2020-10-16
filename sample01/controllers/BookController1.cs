using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sample01.model;
using sample01.Repository;

namespace sample01.controllers
{
    public class BookController1 : Controller
    {
        private readonly BookRepo bookRepository = null;

        public BookController1()
        {
            bookRepository = new BookRepo();
        }


        public ViewResult GetAllBooks()
        {
            // return bookRepository.GetAllBooks();
            return View();
        }

        public BookModel GetBook(int id) 
        {
            return bookRepository.GetoneBook(id);
        }

        public List<BookModel> SearchBook(String title, String author)
        {
            return bookRepository.searchBook(title,author);
        }
    }



}
