using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoP2
{
    public partial class frmNotafiscal : Form
    {
        Decimal t;
        Decimal d=0;
        Decimal cart = 0;
        Decimal ti=0;
        Decimal ch=0;
        Decimal desc = 0;
        Decimal outr = 0;

        public frmNotafiscal(Decimal dinheiro, Decimal troco, Decimal cartao, Decimal tichet, Decimal cheque, Decimal descontos, Decimal outros)
        {
            InitializeComponent();
            d = dinheiro;
            t = troco;
            cart = cartao;
            ti = tichet;
            ch = cheque;
            desc = descontos;
            outr = outros;
        }
        Conexao conn = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;


        int dados = 0;
        String dados1 = "";
        Decimal dados2 = 0;
        Decimal dados3 = 0;
        Decimal dados4 = 0;
        int dados5 = 0;
        String[] descricao;
        int[] id_cliente;
        int[] id_produto;
        Decimal[] valorunit;
        Decimal[] p_total;
        Decimal dados6;
        String data;
        String hora;


        private void button1_Click(object sender, EventArgs e)
        {


            lbNota.Items.Add("                                                 CUPOM FISCAL            ");
            lbNota.Items.Add(" ESTABELECIMENTO:             SNOOP PET SHOP");
            lbNota.Items.Add(" RUA AV REPUBLICA, Nº  1234 - Marília - SP            ");
            lbNota.Items.Add(" CNPJ: 10.930.155.100.88              ");
            lbNota.Items.Add(" Telefone:    (14) 3415-1677");


            lbNota.Items.Add(" -----------------------------------------------------------------------------------------------------------------------------           ");
            lbNota.Items.Add("           ID     DESCRIÇÃO                                                       VALOR UNITÁRIO           ");

            DAOConsumoCliente c = new DAOConsumoCliente();
            cmd.CommandText = @"select * from Lista ";
            //cmd.Parameters.Clear();

            cmd.Connection = conn.Abrir();
            try
            {
                cmd.Connection = conn.Abrir();
                dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {


                    int i = 0;
                    while (dr.Read())
                    {


                        descricao = new String[30];
                        id_cliente = new int[30];
                        id_produto = new int[30];
                        valorunit = new Decimal[30];
                        p_total = new Decimal[30];

                        dados5 = id_cliente[5] = dr.GetInt32(5);
                        dados = id_produto[1] = dr.GetInt32(2);
                        dados1 = descricao[2] = dr.GetString(1);
                        dados3 = valorunit[3] = dr.GetDecimal(3);
                        dados4 = p_total[4] = dr.GetDecimal(4);
                        hora = dr.GetString(6);
                        data = dr.GetString(7);
                        lbNota.Items.Add("           " + dados + "    " + dados1 + "" + "                                    " + dados3);

                        i++;

                    }


                }
                conn.fechar();
            }
            catch (SqlException)
            {
            }
            Decimal total = dados6 + 2;


            lbNota.Items.Add(" SUBTOTAL R$:                                                       " + dados6);
            lbNota.Items.Add(" ICMS:                                                              " + 1.50);
            lbNota.Items.Add(" --------------------------------------------------------------------------------------------------------------------------     ");
            lbNota.Items.Add(" TOTAL R$:                                                                         " + dados6);
            lbNota.Items.Add(" DINHEIRO R$                                                                       " + d);
            lbNota.Items.Add(" TROCO R$:                                                                         " + t);
            lbNota.Items.Add(" CARTÃO R$:                                                                       " + cart);
            lbNota.Items.Add(" CHEQUE R$:                                                                       " + ch);
            lbNota.Items.Add(" TICKET R$:                                                                        " + ti);
            lbNota.Items.Add(" DESCONTOS R$:                                                                    " + desc);
            lbNota.Items.Add(" OUTROS R$:                                                                         " +   outr);
            lbNota.Items.Add("-------------------------------------------------------------------------------------------------------------------------------");
            lbNota.Items.Add(" CÓDIGO DO CLIENTE:     " + dados5);

            lbNota.Items.Add(" DATA: " + data + "                 HORA:" + hora);
            c.excluirTudo();
        }

        private void frmNotafiscal_Load(object sender, EventArgs e)
        {

            cmd.CommandText = @"select sum(p_valorunit) from Lista ";
            //cmd.Parameters.Clear();

            cmd.Connection = conn.Abrir();
            try
            {
                cmd.Connection = conn.Abrir();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                        try
                        {
                            dados6 = dr.GetDecimal(0);
                        }
                        catch
                        {

                        }



                    }
                }
                conn.fechar();
            }
            catch (SqlException)
            {

            }



            // c.excluirTudo();
        }
        private void button3_Click(object sender, EventArgs e)
        {

            frmPagamento p = new frmPagamento("",0,0,"","", 0);
            p.fechar();
            
            Close();


        }

        private void pd1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int altura = 80;
            for (int i = 0; i < lbNota.Items.Count; i++)
            {
                lbNota.SelectedIndex = i;
                e.Graphics.DrawString(lbNota.SelectedItem.ToString(), lbNota.Font, new SolidBrush(lbNota.ForeColor), 80, altura, StringFormat.GenericDefault);

                altura += lbNota.ItemHeight;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pprevier1.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
