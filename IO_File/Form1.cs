using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IO_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //System.IO.File.Copy("C:\\Users\\russe\\Pictures\\Borc1.jpg", "C: \\Users\\russe\\OneDrive\\Desktop\\IO\\newpic.jpg", false); 
            this.openFileDialog1.ShowDialog();
            string fn;
            fn = this.openFileDialog1.FileName;
            System.IO.File.Copy(fn, "C: \\Users\\russe\\OneDrive\\Desktop\\IO\\newpic.jpg", false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //System.IO.File.Move("C:\\Users\\russe\\Pictures\\Borc1.jpg", "C: \\Users\\russe\\OneDrive\\Desktop\\IO\\newpic1.jpg");
            this.openFileDialog1.ShowDialog();
            string fn;
            fn = this.openFileDialog1.FileName;
            if (System.IO.File.Exists("C: \\Users\\russe\\OneDrive\\Desktop\\IO\\newpic2.jpg")==true)
            {
                System.IO.File.Delete("C: \\Users\\russe\\OneDrive\\Desktop\\IO\\newpic2.jpg");
            }
            System.IO.File.Move(fn, "C: \\Users\\russe\\OneDrive\\Desktop\\IO\\newpic2.jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string fn;
            fn = this.openFileDialog1.FileName;
            System.IO.File.Delete(fn);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string r;
           r= System.IO.File.Exists("C:\\Users\\russe\\Pictures\\Borc3.jpg").ToString();
            if (r == "true")
            {
                MessageBox.Show("I can see your file!!");
            }
            else
            {
                MessageBox.Show("I cant find shit today!!");
            }
        }
    }
}
