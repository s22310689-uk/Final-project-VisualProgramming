using System;
using System.Windows.Forms;

namespace Final_project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Booknowlabel_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();   
            form2.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
