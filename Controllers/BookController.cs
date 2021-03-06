﻿using DotnetWebApp.Models;
using DotnetWebApp.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace DotnetWebApp.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController() => _bookRepository = new BookRepository();

        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View();
        }

        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<BookModel> SearchBooks(string title, string authorName)
        {
            return _bookRepository.SearchBook(title, authorName);
        }
    }
}