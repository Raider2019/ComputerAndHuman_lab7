using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class FPassword : Form
    {
        public FPassword()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
          
            string password = "Ліхван";
            if (textBox1.Text == password)
            {
                MForm f = new MForm();

                this.Hide();
                f.Show();
           

            }
            else
            {
                MessageBox.Show("Невірно!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
