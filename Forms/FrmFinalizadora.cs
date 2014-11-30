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
    public partial class FrmFinalizadora : Form
    {
        public FrmFinalizadora()
        {
            InitializeComponent();
        }

        int financeiro;
        int parcelas;

        Classes.Banco clBanco = new Classes.Banco();
        Classes.AtendimentoTelefonico clAtt = new Classes.AtendimentoTelefonico();
        public static decimal totalpagamento;

        public static string datafinalizadora;
        public static int vendafinalizadora;
        public static int clientefinalizadora;

        private void FrmFinalizadora_Load(object sender, EventArgs e)
        {
            CarregarFinalizadoras();
            TxtTotal.Text = totalpagamento.ToString();
            TxtValor.Text = totalpagamento.ToString();
        }

        public void CarregarFinalizadoras()
        {
            clBanco.Finalizadoras();
            CmbFinalizadora.DisplayMember = "descricao";
            CmbFinalizadora.DataSource = Classes.Banco.dt;
        }

        private void CmbFinalizadora_SelectedIndexChanged(object sender, EventArgs e)
        {
            financeiro = Convert.ToInt32(((DataRowView)CmbFinalizadora.SelectedValue)["gerafinanceiro"]);
            if (financeiro == 1) // 1 inativo ; 0 ativo
            {
                LblParcelas.Visible = false;
                LblValor.Visible = false;
                TxtParcelas.Visible = false;
                TxtValor.Visible = false;
            }
            else
            {
                LblParcelas.Visible = true;
                LblValor.Visible = true;
                TxtParcelas.Visible = true;
                TxtValor.Visible = true;
            }
            
            parcelas = Convert.ToInt32(((DataRowView)CmbFinalizadora.SelectedValue)["geraparcelas"]);
            if (parcelas == 1) // 1 inativo ; 0 ativo
            {
                LblParcelas.Visible = false;
                LblValor.Visible = false;
                TxtParcelas.Visible = false;
                TxtValor.Visible = false;
            }
            else
            {
                LblParcelas.Visible = true;
                LblValor.Visible = true;
                TxtParcelas.Visible = true;
                TxtValor.Visible = true;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            clAtt.Parcelas = Convert.ToInt32(TxtParcelas.Text);

            clAtt.Descfinalizadora = CmbFinalizadora.Text;//passando descricao D:
            clAtt.Total = Convert.ToDecimal(TxtTotal.Text);

            clAtt.GravarRecebimentos();
            this.DialogResult = DialogResult.OK;
        }
    }
}
