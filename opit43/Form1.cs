using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opit43
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            zanas1.Hide();
            registraciq1.Hide();
            vhod1.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void началоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zanas1.Hide();
            registraciq1.Hide();
            vhod1.Hide();
        }

        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zanas1.Hide();
            registraciq1.Hide();
            vhod1.Show();
            vhod1.BringToFront();
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zanas1.Hide();
            registraciq1.Show();
            registraciq1.BringToFront();
            vhod1.Hide();
        }

        private void заНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zanas1.Show();
            zanas1.BringToFront();
            registraciq1.Hide();
            vhod1.Hide();
        }
    }
}
