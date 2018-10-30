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
    public partial class AddBookDialog : Form
    {
        private IEnumerable<Author> authors = new List<Author>();
        private string ISBN;
        private string Title;
        private string Description;
        private string BookAuthor;

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
        public string _BookAuthor
        {
            get { return BookAuthor; }
            set { BookAuthor = value; }
        }
        public AddBookDialog(IEnumerable<Author> inAuthor)
        {
            this.authors = inAuthor;
            
            InitializeComponent();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            _ISBN = textBoxISBN.Text;
            _Title = textBoxTitle.Text;
            _Description = textBoxDescription.Text;
            _BookAuthor = textBoxAuthor.Text;
           
        }

        private void AddBookDialog_Load(object sender, EventArgs e)
        {
            AuthorsBox.Items.Clear();
            foreach (Author a in this.authors)
            {
                AuthorsBox.Items.Add(a.Name);
            }
            AuthorsBox.Items.Add("HeyHEYYYYY");
        }
    }
}
