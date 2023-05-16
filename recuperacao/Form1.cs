using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recuperacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form2 ex2 = new Form2();
            ex2.Show();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        public void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void veterinárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ex1 = new Form2();
            ex1.Show();
        }

        private void veterinárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consultar ex1 = new consultar();
            ex1.Show();
        }
    }
}
