using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoP2
{
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProduto p = new frmProduto();
            p.ShowDialog();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmProduto p = new frmProduto();
            p.ShowDialog();
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            cmdMes.Select();
        }

        private void cmdMes_Enter(object sender, EventArgs e)
        {
            cmdMes.BackColor = System.Drawing.Color.LightBlue;
        }

        private void cmdMes_Leave(object sender, EventArgs e)
        {
            cmdMes.BackColor = System.Drawing.Color.White;
        }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            mskDataini.BackColor = System.Drawing.Color.LightBlue;
        }

        private void mskDatafim_Enter(object sender, EventArgs e)
        {
            mskDatafim.BackColor = System.Drawing.Color.LightBlue;
        }

        private void mskDataini_Leave(object sender, EventArgs e)
        {
            mskDataini.BackColor = System.Drawing.Color.White;
        }

        private void mskDatafim_Leave(object sender, EventArgs e)
        {
            mskDatafim.BackColor = System.Drawing.Color.White;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
