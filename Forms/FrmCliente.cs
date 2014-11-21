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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        // Bloco de variáveis.
        int id_estado;
        int id_perfil;

        //Bloco de instâncias de classe.
        Classes.Banco clBanco = new Classes.Banco();
        Classes.Cliente clCliente = new Classes.Cliente();
        Classes.Conversao clConversao = new Classes.Conversao();
        Classes.Validacao clValidacao = new Classes.Validacao();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbPessoa.SelectedIndex == 0)
            {
                LblCnpj.Visible = false;
                MtbCnpj.Visible = false;
                LblCpf.Visible = true;
                MtbCpf.Visible = true;
                LblIe.Visible = false;
                LblRg.Visible = true;
            }

            if (CmbPessoa.SelectedIndex == 1)
            {
                LblCpf.Visible = false;
                MtbCpf.Visible = false;
                LblCnpj.Visible = true;
                MtbCnpj.Visible = true;
                LblIe.Visible = true;
                LblRg.Visible = false;
            }
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            CmbPessoa.SelectedIndex = 0;
            CarregarEstado();
        }

        //Métodos.
        public void CarregarEstado()
        {
            clBanco.Estado();
            CmbEstado.DisplayMember = "nome";
            CmbEstado.DataSource = Classes.Banco.dt;
        }

        private void CmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbEstado.ValueMember = "id";
            id_estado = Convert.ToInt32(CmbEstado.SelectedValue);
            clBanco.Cidade(id_estado);
            CmbCidade.DataSource = Classes.Banco.dt;
            CmbCidade.DisplayMember = "nome";
            CmbCidade.ValueMember = "id";
        }

        public void cidade()
        {
            try
            {
                clBanco.Conectar();
                MySqlCommand sql = new MySqlCommand("SELECT nome FROM cidade WHERE id = '" + clCliente.Cidade_id + "';", clBanco.Conn);
                MySqlDataReader dr = sql.ExecuteReader();
                if (dr.Read())
                {
                    CmbCidade.Text = dr["nome"].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }
            finally
            {
                clBanco.FecharConexao();
            }
        }

        public void estado()
        {
            try
            {
                clBanco.Conectar();
                MySqlCommand sql = new MySqlCommand("SELECT nome FROM estado WHERE id = '" + clCliente.Estado_id + "';", clBanco.Conn);
                MySqlDataReader dr = sql.ExecuteReader();
                if (dr.Read())
                {
                    CmbEstado.Text = dr["nome"].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }
            finally
            {
                clBanco.FecharConexao();
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
                clCliente.Inativar();
                Limpar();
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

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //idempresa
            //clValidacao.ValidarCnpj(MtbCpf.Text);
            //clValidacao.ExistenciaCnpj(MtbCpf.Text);

            //if (Classes.Validacao.retornovalidacao == true)
            //{
               // if (Classes.Validacao.retornovalidacaoigualdade == false)
               // {
                    // chamar e testar validação de senha existencia
                    clCliente.Cpfcnpj = MtbCpf.Text;
                    clCliente.Rgie = TxtRg.Text;
                    clCliente.Nome = TxtNome.Text;

                    if (CmbSexo.Text == "Feminino") { clCliente.Sexo = 0; }
                    if (CmbSexo.Text == "Masculino") { clCliente.Sexo = 1; }

                    clCliente.Datacadastro = clConversao.ConverterData(DtpDataCadastro.Text);
                    clCliente.Datanascimento = clConversao.ConverterData(DtpDatanascimento.Text);
                    clCliente.Endereco = TxtEndereco.Text;
                    clCliente.Bairro = TxtBairro.Text;
                    clCliente.Numero = TxtNumero.Text;
                    clCliente.Complemento = TxtComplemento.Text;
                    clCliente.Cidade_id = Convert.ToInt32(CmbCidade.SelectedValue);
                    clCliente.Estado_id = Convert.ToInt32(CmbEstado.SelectedValue);
                    clCliente.Cep = MtbCep.Text;
                    clCliente.Telefone = MtbTelefone.Text;
                    clCliente.Celular = MtbCelular.Text;
                    clCliente.Email = TxtEmail.Text;
                    clCliente.Observacao = TxtObservacao.Text;

                    if (CkbStatus.Checked == true) { clCliente.Status = 0; }
                    if (CkbStatus.Checked == false) { clCliente.Status = 1; }


                    if (TxtCodigo.Text == "")
                    {
                        //Classes.Usuario.tipousuario = false;
                        try
                        {
                            clCliente.Salvar();
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
                        //Classes.Cliente.tipousuario = true;
                        try
                        {
                            clCliente.Editar();
                            MessageBox.Show("Dados editados com sucesso!", "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpar();
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show("Não foi salvar as alterações.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                /*}
                else
                {
                    MessageBox.Show("CPF/CNPJ existente.");
                }
            }
            else
            {
                MessageBox.Show("Favor informar um CPF/CNPJ válido.");
            }*/
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Forms.GrdCliente grCliente = new Forms.GrdCliente();

            if (grCliente.ShowDialog() == DialogResult.OK)
            {
                clCliente.Retornar();
                TxtCodigo.Text = Classes.Cliente.idcliente.ToString();
                DtpDataCadastro.Text = clCliente.Datacadastro;
                MtbCpf.Text = clCliente.Cpfcnpj;
                TxtRg.Text = clCliente.Rgie;
                TxtNome.Text = clCliente.Nome;
                if (clCliente.Sexo == 0) { CmbSexo.SelectedIndex = 0; }
                if (clCliente.Sexo == 1) { CmbSexo.SelectedIndex = 1; }
                DtpDatanascimento.Text = clCliente.Datanascimento;
                TxtEndereco.Text = clCliente.Endereco;
                TxtBairro.Text = clCliente.Bairro;
                TxtNumero.Text = clCliente.Numero;
                TxtComplemento.Text = clCliente.Complemento;
                estado();
                cidade();
                MtbCep.Text = clCliente.Cep;
                MtbTelefone.Text = clCliente.Telefone;
                MtbCelular.Text = clCliente.Celular;
                TxtEmail.Text = clCliente.Email;
                TxtObservacao.Text = clCliente.Observacao;
                if (clCliente.Status == 0) { CkbStatus.Checked = true; }
                if (clCliente.Status == 1) { CkbStatus.Checked = false; }
            }
        }
    }
}
