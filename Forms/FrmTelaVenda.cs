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
    public partial class FrmTelaVenda : Form
    {
        public FrmTelaVenda()
        {
            InitializeComponent();
        }

        Classes.Banco clBanco = new Classes.Banco();
        Classes.Mercadoria clMercadoria = new Classes.Mercadoria();

        string varbarras;
        decimal somafinal;

        private void FrmTelaVenda_Load(object sender, EventArgs e)
        {
            CarregarMercadoria();
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

        public void CarregarMercadoria()
        {
            clBanco.Mercadoria();
            CmbMercadoria.DisplayMember = "descricao";
            CmbMercadoria.DataSource = Classes.Banco.dt;

            TxtValorUnitario.Text = ((DataRowView)CmbMercadoria.SelectedValue)["precovenda"].ToString();
            varbarras = ((DataRowView)CmbMercadoria.SelectedValue)["codigodebarras"].ToString();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            //ItensGrid(); // Adiciona os itens na grid
            //RecalculaValores();
        }

        private void CmbMercadoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtValorUnitario.Text = ((DataRowView)CmbMercadoria.SelectedValue)["precovenda"].ToString();
            SomaItem();
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
    }
}
