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
    public partial class FrmRecebimentos : Form
    {
        public FrmRecebimentos()
        {
            InitializeComponent();
        }

        Classes.Re

        private void FrmRecebimentos_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();

            if (MessageBox.Show("Deseja fechar a janela?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void Limpar()
        {
            foreach (Control c in this.Controls)
            {

                if (c is TextBox)
                    ((TextBox)c).Text = string.Empty;

                /*else if (c is CheckBox)
                    ((CheckBox)c).Checked = false;*/

                else if (c is MaskedTextBox)
                    ((MaskedTextBox)c).Text = string.Empty;

                else if (c is DateTimePicker)
                    ((DateTimePicker)c).Text = string.Empty;
            }

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o registro?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (resultado == DialogResult.OK)
            {
                clRecebimenos.Inativar();
                Limpar();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Forms.GrdRecebimento grRecebimento = new Forms.GrdRecebimento();
            if (grRecebimento.ShowDialog() == DialogResult.OK)
            {
                clRecebimento.Retornar();
                TxtCodigo.Text = Classes.Recebimento.idrecebimento.ToString();
                DtpDataCadastro.Text = clRecebimento.Datacadastro;
                TxtFinalizadora.Text = clRecebimento.Finalizadora;
                TxtVenda.Text = clRecebimento.NVenda;
                CmbCliente.Text = clRecebimento.Cliente;
                TxtDescricao.Text = clRecebimento.Descricao;
                if (clRecebimento.Quitado == 0) { CmbQuitado.Text = "Sim"; }
                if (clRecebimento.Quitado == 1) { CmbQuitado.Text = "Não"; }
                TxtParcelas.Text = clRecebimentos.Parcelas;
                TxtTotal.Text = clRececimentos.Total;

                if (clRecebimentos.Status == 0) { CkbStatus.Checked = true; }
                if (clRecebimentos.Status == 1) { CkbStatus.Checked = false; }
            }
        }
    }
}
