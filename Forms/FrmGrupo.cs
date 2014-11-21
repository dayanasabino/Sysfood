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
    public partial class FrmGrupo : Form
    {
        public FrmGrupo()
        {
            InitializeComponent();
        }

        Classes.Banco clBanco = new Classes.Banco();
        Classes.Grupo clGrupo = new Classes.Grupo();
        Classes.Conversao clConversao = new Classes.Conversao();

        private void FrmGrupo_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            clGrupo.Datacadastro = clConversao.ConverterData(DtpDataCadastro.Text);

            clGrupo.Descricao = TxtDescricao.Text;

            if (CkbStatus.Checked == true) { clGrupo.Status = 0; }
            if (CkbStatus.Checked == false) { clGrupo.Status = 1; }


            if (TxtCodigo.Text == "")
            {
                //Classes.Usuario.tipousuario = false;
                try
                {
                    clGrupo.Salvar();
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
                    clGrupo.Editar();
                    MessageBox.Show("Dados editados com sucesso!", "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não foi salvar as alterações.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Forms.GrdGrupo grGrupo = new Forms.GrdGrupo();
            //grUsuario.Show();

            if (grGrupo.ShowDialog() == DialogResult.OK)
            {
                clGrupo.Retornar();
                TxtCodigo.Text = Classes.Grupo.idgrupo.ToString();
                DtpDataCadastro.Text = clGrupo.Datacadastro;
                TxtDescricao.Text = clGrupo.Descricao;
                if (clGrupo.Status == 0) { CkbStatus.Checked = true; }
                if (clGrupo.Status == 1) { CkbStatus.Checked = false; }
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o registro?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (resultado == DialogResult.OK)
            {
                clGrupo.Inativar();
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
    }
}
