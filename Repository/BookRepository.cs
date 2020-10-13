using DotnetWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetWebApp.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title == title || x.Author == authorName).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() {Id = 1, Title = "MVC", Author = "ARS"},
                new BookModel() {Id = 2, Title = "Dot Net Core", Author = "ARS"},
                new BookModel() {Id = 3, Title = "C#", Author = "Shawn"},
                new BookModel() {Id = 4, Title = "Java", Author = "ARS"},
                new BookModel() {Id = 5, Title = "HTML", Author = "Artin"}
            };
        }
    }
}
