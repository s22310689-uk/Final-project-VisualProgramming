using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
    

    private void CenterPanel()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }
    }
}

