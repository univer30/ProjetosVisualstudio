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
    public partial class frmAnimal : Form
    {
        public frmAnimal()
        {
            InitializeComponent();
        }
        public Cliente getCliente()
        {
            Cliente c = new Cliente();
            c.idcliente = Convert.ToInt32(txtCliente.Text);
            return c;
        }
        public void setcliente(Cliente c)
        {
            txtCliente.Text = c.idcliente.ToString();
        }

       public  void setAnimal(Animal a)
        {
            txtcodigo.Text = a.id.ToString();
            txtNome.Text = a.nome;
            txtRaca.Text = a.raca;
            txtaCor.Text = a.cor;
            txtCliente.Text = a.Cliente.ToString();
        }

        public Animal GetAnimal()
        {
            Animal a = new Animal();
            a.id = Convert.ToInt32(txtcodigo.Text);
            a.nome = txtNome.Text;
            a.raca = txtRaca.Text;
            a.cor = txtaCor.Text;
            a.Cliente = Convert.ToInt32(txtCliente.Text);
            return a;
        }
        public Animal GetAnimal2()
        {
            Animal a = new Animal();
         
            a.nome = txtNome.Text;
            a.raca = txtRaca.Text;
            a.cor = txtaCor.Text;
            a.Cliente = Convert.ToInt32(txtCliente.Text);
            return a;
        }

        void Limpartela()
        {
            txtcodigo.Clear();
            txtNome.Clear();
            txtRaca.Clear();
            txtaCor.Clear();
            txtCliente.Clear();
        }
        private void botaoAdicionar()
        {
            btnadicionar.Enabled = true;
            btnexcluir.Enabled = false;
            btnalterar.Enabled = false;
        }
        private void botaoAlterarExcluir()
        {
            btnadicionar.Enabled = false;
            btnexcluir.Enabled = true;
            btnalterar.Enabled = true;
        }
        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            try
            {


                DAOAnimal a = new DAOAnimal();
                a.inserir(GetAnimal2());
                Limpartela();
            }
            catch
            {
                MessageBox.Show("Dados em branco!");
            }
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            frmListaAnimal a = new frmListaAnimal();
            a.ShowDialog();

            if (a.DialogResult == DialogResult.OK)
            {
                setAnimal(a.getAnimalLista());
                botaoAlterarExcluir();
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DAOAnimal an = new DAOAnimal();
                an.excluir(GetAnimal());
                Limpartela();

            }
            catch
            {
                MessageBox.Show("Não foi possível excluir");

            }
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            try
            {
                DAOAnimal an = new DAOAnimal();
                an.alterar(GetAnimal());
                Limpartela();
            }
            catch
            {
                MessageBox.Show("Não foi possível Alterar");
            }
           
        }

        private void btnpesqcliente_Click(object sender, EventArgs e)
        {
           
        }

        private void frmAnimal_Load(object sender, EventArgs e)
        {
            txtcodigo.Enabled = false;
            txtNome.Select();
        }

        private void txtaCor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtNome.BackColor = System.Drawing.Color.LightBlue;
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            txtNome.BackColor = System.Drawing.Color.White;
        }

        private void txtRaca_Enter(object sender, EventArgs e)
        {
            txtRaca.BackColor = System.Drawing.Color.LightBlue;
        }

        private void txtRaca_Leave(object sender, EventArgs e)
        {
            txtRaca.BackColor = System.Drawing.Color.White;
        }

        private void txtaCor_Enter(object sender, EventArgs e)
        {
            txtaCor.BackColor = System.Drawing.Color.LightBlue;
        }

        private void txtaCor_Leave(object sender, EventArgs e)
        {
            txtaCor.BackColor = System.Drawing.Color.White;
        }

        private void txtCliente_Enter(object sender, EventArgs e)
        {
            txtCliente.BackColor = System.Drawing.Color.LightBlue;
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            txtCliente.BackColor = System.Drawing.Color.White;
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                this.AcceptButton = btnconsultar;       
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultacliente c = new consultacliente();
            c.ShowDialog();

            if (c.DialogResult == DialogResult.OK)
            {

                setcliente(c.GetCliente());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
