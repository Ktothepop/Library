using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;

namespace Library
{
    /// <summary>
    /// Dialog window for creating Book object
    /// </summary>
    public partial class AddBookDialog : Form
    {
        private IEnumerable<Author> authors = new List<Author>();
        private string ISBN;
        private string Title;
        private string Description;
        private Author BookAuthor;

        public string _ISBN
        {
            get { return ISBN; }
            set { ISBN = value; }
        }
        public string _Title
        {
            get { return Title; }
            set { Title = value; }
        }
        public string _Description
        {
            get { return Description; }
            set { Description = value; }
        }
        public Author _BookAuthor
        {
            get { return BookAuthor; }
            set { BookAuthor = value; }
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="inAuthor">
        /// List of Author(s)
        /// </param>
        public AddBookDialog(IEnumerable<Author> inAuthor)
        {
            this.authors = inAuthor;

            InitializeComponent();
        }
        /// <summary>
        /// Gets string values from textboxes
        /// </summary>
        /// <param name="sender">
        /// Object reference
        /// </param>
        /// <param name="e">
        /// Event data
        /// </param>
        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            _ISBN = textBoxISBN.Text;
            _Title = textBoxTitle.Text;
            _Description = textBoxDescription.Text;
            _BookAuthor = (Author)AuthorsBox.SelectedItem;

        }
        /// <summary>
        /// Displays Authors in Authorsbox
        /// </summary>
        /// <param name="sender">
        /// Object reference
        /// </param>
        /// <param name="e">
        /// Event data
        /// </param>
        private void AddBookDialog_Load(object sender, EventArgs e)
        {
            AuthorsBox.Items.Clear();
            foreach (Author a in this.authors)
            {
                AuthorsBox.Items.Add(a);
            }

        }


    }
}
