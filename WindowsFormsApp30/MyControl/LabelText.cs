using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyControl
{
    public partial class LabelText : UserControl
    {
        public LabelText()
        {
            InitializeComponent();
        }

        private String myText;
        private String myContent;
        private char passwordChar;

        public String MyContent
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public String MyText
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public char PasswordChar
        {
            get { return textBox1.PasswordChar; }
            set { textBox1.PasswordChar = value; }
        }
    }
}
