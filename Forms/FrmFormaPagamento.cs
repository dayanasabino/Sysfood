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
    public partial class FrmFormaPagamento : Form
    {
        public FrmFormaPagamento()
        {
            InitializeComponent();
        }

        Classes.FormaPagamento clPagamento = new Classes.FormaPagamento();
        Classes.Conversao clConversao = new Classes.Conversao();

        private void FrmFormaPagamento_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            clPagamento.Datacadastro = clConversao.ConverterData(DtpDataCadastro.Text);

            clPagamento.Descricao = TxtDescricao.Text;

            if (CkbStatus.Checked == true) { clPagamento.Status = 0; }
            if (CkbStatus.Checked == false) { clPagamento.Status = 1; }


            if (TxtCodigo.Text == "")
            {
                //Classes.Usuario.tipousuario = false;
                try
                {
                    clPagamento.Salvar();
                    Limpar();
                    MessageBox.Show("Dados gravados com sucesso!", "Confirmação.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não foi possível gravar os dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Classes.Usuario.tipousuario = true;
                try
                {
                    clPagamento.Editar();
                    MessageBox.Show("Dados editados com sucesso!", "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não foi salvar as alterações.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Forms.GrdFormaPagamento grPagamento = new Forms.GrdFormaPagamento();
            //grUsuario.Show();

            if (grPagamento.ShowDialog() == DialogResult.OK)
            {
                clPagamento.Retornar();
                TxtCodigo.Text = Classes.FormaPagamento.idpagamento.ToString();
                DtpDataCadastro.Text = clPagamento.Datacadastro;
                TxtDescricao.Text = clPagamento.Descricao;
                if (clPagamento.Status == 0) { CkbStatus.Checked = true; }
                if (clPagamento.Status == 1) { CkbStatus.Checked = false; }
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o registro?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (resultado == DialogResult.OK)
            {
                clPagamento.Inativar();
                Limpar();
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();

            if (MessageBox.Show("Deseja fechar a janela?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
