using Microsoft.AspNetCore.Mvc;

namespace DotnetWebApp.Controllers
{
    public class BookController : Controller
    {
        public string GetAllBooks()
        {
            return "All books";
        }

        public string GetBook(int id)
        {
            return $"Book with id = {id}";
        }

        public string SearchBooks(string bookName, string authorName)
        {
            return $"Book name = {bookName} & Author = {authorName}";
        }
    }
}