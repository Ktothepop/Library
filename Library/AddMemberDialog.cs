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
  public partial class AddMemberDialog : Form
  {
    private string MemberName;
    private int SSN;
    public string _Name
    {
      get { return MemberName; }
      set { MemberName = value; }
    }
    public int _SSN
    {
      get { return SSN; }
      set { SSN = value; }
    }
    public AddMemberDialog()
    {
      InitializeComponent();
    }

    private void buttonAddMember_Click(object sender, EventArgs e)
    {
      _Name = textBoxName.Text;
      if (this.textBoxSSN.Text == "")
        _SSN = 0;
      else try {
          _SSN = Convert.ToInt32(this.textBoxSSN.Text);
        } catch (Exception ex) {
          if (ex is FormatException || ex is OverflowException)
            _SSN = 0;
        }

    }
  }
}
