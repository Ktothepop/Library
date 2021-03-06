﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
  /// <summary>  
  ///  Book object class 
  /// </summary>  
  public class Book
  {
    [Key]
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string ISBN { get; set; }
    public string Description { get; set; }
    [Required]
    public virtual Author Author { get; set; }
    public virtual ICollection<BookCopy> BookCopies { get; set; }
    /// <summary>
    /// Useful for adding the Book objects directly to a ListBox.
    /// </summary>
    /// <returns>
    /// A string representation of the object
    /// </returns>
    public override string ToString()
    {
      int bookCopyCount = 0;
      if (this.BookCopies != null) {
        foreach (BookCopy bc in this.BookCopies) {
          if(bc.IsLoaned == false)
          bookCopyCount += 1;
        }
      }
      return String.Format("{0}", this.Title + " | Available Qty: " + bookCopyCount);
    }
  }
}