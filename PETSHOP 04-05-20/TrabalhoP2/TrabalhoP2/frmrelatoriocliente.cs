﻿using System;
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
    public partial class frmrelatoriocliente : Form
    {
        public frmrelatoriocliente()
        {
            InitializeComponent();
        }

        private void frmrelatoriocliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'LojaDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.ClienteTableAdapter.Fill(this.LojaDataSet.Cliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
