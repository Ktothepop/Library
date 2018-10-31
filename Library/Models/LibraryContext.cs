using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Library.Models {
    /// <summary>
    /// Derived context. 
    /// Extends the DbContext class
    /// </summary>
    public class LibraryContext : DbContext {
        /// This context is configured to use a 'LibraryContext' 
        /// connection string from this application's 
        /// configuration file (App.config or Web.config). By default, 
        /// connection string targets the 
        /// 'Library.Models.LibraryContext' database on the LocalDb instance. 
        /// If you wish to target a different database and/or database
        /// provider, modify the 'LibraryContext' 
        /// connection string in the application configuration file.
        public LibraryContext(){
            // Database strategy
            Database.SetInitializer<LibraryContext>(new LibraryDbInit());
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookCopy> BookCopies { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Member> Members { get; set; }

        /// <summary>
        /// Configures the model before locked down
        /// </summary>
        /// <param name="modelBuilder">The modelbuilder</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
        }
    }
}