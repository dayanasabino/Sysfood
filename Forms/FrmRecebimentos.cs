using MySql.Data.MySqlClient;
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

        Classes.Recebimento clRecebimento = new Classes.Recebimento();
        Classes.Banco clBanco = new Classes.Banco();
        Classes.Conversao clConversao = new Classes.Conversao();
        Classes.Cliente clCliente = new Classes.Cliente();

        private void FrmRecebimentos_Load(object sender, EventArgs e)
        {
            CarregarCliente();
        }

        public void CarregarCliente()
        {
            clBanco.Cliente();
            CmbCliente.DisplayMember = "nome";
            CmbCliente.DataSource = Classes.Banco.dt;
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
                clRecebimento.Inativar();
                Limpar();
            }
        }

        public void Cliente()
        {
            clBanco.Conectar();
            MySqlCommand sql = new MySqlCommand("SELECT nome FROM cliente WHERE id = '" + clRecebimento.Cliente + "';", clBanco.Conn);
            MySqlDataReader dr = sql.ExecuteReader();
            if (dr.Read())
            {
                CmbCliente.Text = dr["nome"].ToString();
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
                TxtVenda.Text = clRecebimento.NVenda.ToString();
                Cliente();
                //CmbCliente.Text = clRecebimento.Cliente;
                TxtDescricao.Text = clRecebimento.Descricao;

                if (clRecebimento.Quitado == 0) { CmbQuitado.Text = "Sim"; }
                if (clRecebimento.Quitado == 1) { CmbQuitado.Text = "Não"; }

                TxtParcelas.Text = clRecebimento.Parcelas.ToString();
                TxtTotal.Text = clRecebimento.Total.ToString();

                if (clRecebimento.Status == 0) { CkbStatus.Checked = true; }
                if (clRecebimento.Status == 1) { CkbStatus.Checked = false; }
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            clRecebimento.Datacadastro = clConversao.ConverterData(DtpDataCadastro.Text);
            clRecebimento.Finalizadora = TxtFinalizadora.Text;
            clRecebimento.NVenda = Convert.ToInt32(TxtVenda.Text);
            clRecebimento.Cliente = Convert.ToInt32(((DataRowView)CmbCliente.SelectedValue)["id"]);
            clRecebimento.Descricao = TxtDescricao.Text;
            clRecebimento.Parcelas = Convert.ToInt32(TxtParcelas.Text);
            clRecebimento.Total = Convert.ToDecimal(TxtTotal.Text);

            if (CkbStatus.Checked == true) { clRecebimento.Status = 0; }
            if (CkbStatus.Checked == false) { clRecebimento.Status = 1; }


            if (CmbQuitado.Text == "Sim") { clRecebimento.Quitado = 0; }
            if (CmbQuitado.Text == "Não") { clRecebimento.Quitado = 1; }

            if (TxtCodigo.Text == "")
            {
                try
                {
                    clRecebimento.Salvar();
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
                try
                {
                    clRecebimento.Editar();
                    MessageBox.Show("Dados editados com sucesso!", "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não foi salvar as alterações.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            }
        }
    }
}
