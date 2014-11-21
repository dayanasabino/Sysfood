using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysFood.Forms
{
    public partial class FrmAtendimentoTelefonico : Form
    {
        public FrmAtendimentoTelefonico()
        {
            InitializeComponent();
        }

        Classes.Banco clBanco = new Classes.Banco();
        Classes.Mercadoria clMercadoria = new Classes.Mercadoria();
        Classes.Cliente clCliente = new Classes.Cliente();

        string varbarras;

        private void FrmAtendimentoTelefonico_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            CarregarCliente();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            BtnSalvar.Enabled = false;
            CarregarMercadoria();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            BtnSalvar.Enabled = true;
            ItensGrid(); // Adiciona os itens na grid
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            BtnSalvar.Enabled = true;
        }

        public void CarregarCliente()
        {
            clBanco.Cliente();
            CmbCliente.DisplayMember = "nome";
            CmbCliente.DataSource = Classes.Banco.dt;

            TxtEndereco.Text = ((DataRowView)CmbCliente.SelectedValue)["endereco"].ToString()
                +", "+ ((DataRowView)CmbCliente.SelectedValue)["numero"].ToString()
                +", "+ ((DataRowView)CmbCliente.SelectedValue)["bairro"].ToString();

            MtbTelefone.Text = ((DataRowView)CmbCliente.SelectedValue)["telefone"].ToString();
        }

        private void CmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtEndereco.Text = ((DataRowView)CmbCliente.SelectedValue)["endereco"].ToString()
               + ", " + ((DataRowView)CmbCliente.SelectedValue)["numero"].ToString()
               + ", " + ((DataRowView)CmbCliente.SelectedValue)["bairro"].ToString();

            MtbTelefone.Text = ((DataRowView)CmbCliente.SelectedValue)["telefone"].ToString();
        }

        public void CarregarMercadoria()
        {
            clBanco.Mercadoria();
            CmbMercadoria.DisplayMember = "descricao";
            CmbMercadoria.DataSource = Classes.Banco.dt;

            TxtValorUnitario.Text = ((DataRowView)CmbMercadoria.SelectedValue)["precovenda"].ToString();
            varbarras = ((DataRowView)CmbMercadoria.SelectedValue)["codigodebarras"].ToString();
        }

        private void CmbMercadoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtValorUnitario.Text = ((DataRowView)CmbMercadoria.SelectedValue)["precovenda"].ToString();
            SomaItem();
        }

        private void BtnBuscaProduto_Click(object sender, EventArgs e)
        {
            Forms.GrdMercadoria grMerc = new GrdMercadoria();
            if (grMerc.ShowDialog() == DialogResult.OK)
            {
                clMercadoria.Retornar();
                //TxtCodigo.Text = Classes.Mercadoria.idmercadoria.ToString();
                varbarras = clMercadoria.Codigodebarras.ToString();
                CmbMercadoria.Text = clMercadoria.Descricao;
                TxtValorUnitario.Text = clMercadoria.Precovenda.ToString();
            }
        }

        public void SomaItem()
        {
            decimal soma, qtd, vu;
            qtd = Convert.ToDecimal(TxtQuantidade.Text);
            vu = Convert.ToDecimal(TxtValorUnitario.Text);
            soma = qtd * vu;
            TxtTotalParcial.Text = soma.ToString();
        }

        private void TxtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (TxtQuantidade.Text != "")
            {
                SomaItem();
            }
        }

        private void BtnBuscaCliente_Click(object sender, EventArgs e)
        {
            Forms.GrdCliente grCliente = new Forms.GrdCliente();

            if (grCliente.ShowDialog() == DialogResult.OK)
            {
                clCliente.Retornar();
                //TxtCodigo.Text = Classes.Cliente.idcliente.ToString();
                CmbCliente.Text = clCliente.Nome;
                TxtEndereco.Text = clCliente.Endereco + 
                    ", " + clCliente.Numero + ", " + clCliente.Bairro;
                MtbTelefone.Text = clCliente.Telefone;
            }

        }

        public void ItensGrid()
        {
            dataGridView1.Rows.Add(dataGridView1.RowCount, varbarras, CmbMercadoria.Text, TxtQuantidade.Text, TxtValorUnitario.Text, TxtTotalParcial.Text);
        }
    }
}
