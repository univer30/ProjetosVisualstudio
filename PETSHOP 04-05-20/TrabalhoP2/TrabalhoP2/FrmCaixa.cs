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
    public partial class frmCaixa : Form
    {
        public frmCaixa()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {
            txtDataini.Select();
        }

        private void txtDataini_Enter(object sender, EventArgs e)
        {
            txtDataini.BackColor = System.Drawing.Color.LightBlue;

        }

        private void txtDataini_Leave(object sender, EventArgs e)
        {
            txtDataini.BackColor = System.Drawing.Color.White;
           
        }

        private void txtDatafim_Enter(object sender, EventArgs e)
        {
            txtDatafim.BackColor = System.Drawing.Color.LightBlue;
        }

        private void txtDatafim_Leave(object sender, EventArgs e)
        {
            txtDatafim.BackColor = System.Drawing.Color.White;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
