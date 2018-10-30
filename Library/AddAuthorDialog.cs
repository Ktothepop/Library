using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class AddAuthorDialog : Form
    {
        private string AuthorName;
        public string _Name
        {
            get { return AuthorName; }
            set { AuthorName = value; }
        }
        public AddAuthorDialog()
        {
            InitializeComponent();
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            _Name = textBoxName.Text;
        }
    }
}
