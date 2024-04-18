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

        public Size SizeT
        {
            get { return textBox1.Size; }
            set 
            {
                int lWith= this.Size.Width - value.Width;
                int lHeigh = this.Size.Height - value.Height;
                label1.Size=new Size(lWith, lHeigh);
                textBox1.Size = value; 
            }
        }

        public Size SizeL {
            get { return label1.Size; } 
            set 
            {
                int tWith = this.Size.Width - value.Width;
                int tHeigh = this.Size.Height - value.Height;
                label1.Size = new Size(tWith, tHeigh);
                label1.Size = value;
            }    
        }

        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }
    }
}
