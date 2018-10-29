﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
  public class BookRepository : IRepository<Book, int>
  {
    LibraryContext context;

    public BookRepository(LibraryContext c)
    {
      this.context = c;
    }
    //Samtliga funktioner här ska utnyttja Linq
    //ser ut såhär, frågan är om man gör en kontroll här eller tidigare? Borde kanske alltid kontrolleras?
    public IEnumerable<Book> All()
    {
      return context.Books;
    }

    public void Edit(Book b)
    {
      context.SaveChanges();
    }

    public void Add(Book a)
    {
      context.Books.Add(a);
      context.SaveChanges();
    }
    public void Remove(Book a)
    {
      context.Books.Remove(a);
      context.SaveChanges();
    }
    public Book Find(int inID)
    {
      return context.Books.Find(inID);
    }
  }
}