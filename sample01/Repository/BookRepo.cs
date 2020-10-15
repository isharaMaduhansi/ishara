using sample01.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample01.Repository
{
    public class BookRepo
    {
        public List<BookModel> GetAllBooks() 
        {
            return DataSource();
        }

        public BookModel GetoneBook(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> searchBook(String title,String author)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }

        public List<BookModel> DataSource()
        {
            return new List<BookModel>()
          {
              new BookModel(){Id=1, Title="MVC", Author="Ish" },
               new BookModel(){Id=2, Title="Java", Author="Hiru" },
                new BookModel(){Id=3, Title="Net", Author="Katta" },
                 new BookModel(){Id=4, Title="Python", Author="Hansi" },
          };
        }
    }
}
