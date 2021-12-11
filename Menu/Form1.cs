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
    public partial class MForm : Form
    {
        public MForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Залиситися?", "Вмйти?", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == DialogResult.No)
                Application.Exit();
        }

        private void infoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Меню розробив(ла)'#13#10'студент(ка) гр.  No 42 Ліхван Дмитро Юрійович", "info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1 );

        }
    }
}
