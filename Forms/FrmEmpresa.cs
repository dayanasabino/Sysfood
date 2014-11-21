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
    public partial class FrmEmpresa : Form
    {
        public FrmEmpresa()
        {
            InitializeComponent();
        }

        // Bloco de variáveis.
        int id_estado;
        int id_perfil;

        //Bloco de instâncias de classe.
        Classes.Banco clBanco = new Classes.Banco();
        Classes.Conversao clConversao = new Classes.Conversao();
        Classes.Validacao clValidacao = new Classes.Validacao();
        Classes.Empresa clEmpresa = new Classes.Empresa();

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
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

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            clEmpresa.Datacadastro = clConversao.ConverterData(DtpDataCadastro.Text);

            //clValidacao.ValidarCnpj(MtbCnpj.Text);
            //clValidacao.ExistenciaCnpj(MtbCnpj.Text); 

            if(Classes.Validacao.retornovalidacao == false)
            {
                clEmpresa.Cnpj = MtbCnpj.Text;
                clEmpresa.Ie = TxtIe.Text;
                clEmpresa.Im = TxtIm.Text;
                clEmpresa.Cnae = TxtCnae.Text;
                clEmpresa.Razaosocial = TxtRazaoSocial.Text;
                clEmpresa.Nomefantasia = TxtNomeFantasia.Text;
                clEmpresa.Endereco = TxtEndereco.Text;
                clEmpresa.Bairro = TxtBairro.Text;
                clEmpresa.Numero = TxtNumero.Text;
                clEmpresa.Complemento = TxtComplemento.Text;
                clEmpresa.Cidade_id = Convert.ToInt32(CmbCidade.SelectedValue);
                clEmpresa.Estado_id = Convert.ToInt32(CmbEstado.SelectedValue);
                clEmpresa.Cep = MtbCep.Text;
                clEmpresa.Telefone = MtbTelefone.Text;
                clEmpresa.Fax = MtbFax.Text;
                clEmpresa.Email = TxtEmail.Text;
                clEmpresa.Observacao = TxtObservacao.Text;

                if (CkbStatus.Checked == true) { clEmpresa.Status = 0; }
                if (CkbStatus.Checked == false) { clEmpresa.Status = 1; }


                if (TxtCodigo.Text == "")
                {
                    //Classes.Usuario.tipousuario = false;
                    try
                    {
                        clEmpresa.Salvar();
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
                    //Classes.Empresa.tipoempresa = true;
                    try
                    {
                        clEmpresa.Editar();
                        MessageBox.Show("Dados editados com sucesso!", "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Não foi salvar as alterações.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Favor informar um CNPJ válido.");
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
            Forms.GrdEmpresa grEmpresa = new Forms.GrdEmpresa();
            //grUsuario.Show();

            if (grEmpresa.ShowDialog() == DialogResult.OK)
            {
                clEmpresa.Retornar();
                TxtCodigo.Text = clEmpresa.Idempresa.ToString();
                DtpDataCadastro.Text = clEmpresa.Datacadastro;
                MtbCnpj.Text = clEmpresa.Cnpj;
                TxtIe.Text = clEmpresa.Ie;
                TxtIm.Text = clEmpresa.Im;
                TxtCnae.Text = clEmpresa.Cnae;
                TxtRazaoSocial.Text = clEmpresa.Razaosocial;
                TxtNomeFantasia.Text = clEmpresa.Nomefantasia;
                TxtEndereco.Text = clEmpresa.Endereco;
                TxtBairro.Text = clEmpresa.Bairro;
                TxtNumero.Text = clEmpresa.Numero;
                TxtComplemento.Text = clEmpresa.Complemento;
                estado();
                cidade();
                MtbCep.Text = clEmpresa.Cep;
                MtbTelefone.Text = clEmpresa.Telefone;
                MtbFax.Text = clEmpresa.Fax;
                TxtEmail.Text = clEmpresa.Email;
                TxtObservacao.Text = clEmpresa.Observacao;
                if (clEmpresa.Status == 0) { CkbStatus.Checked = true; }
                if (clEmpresa.Status == 1) { CkbStatus.Checked = false; }
            }
        }

        public void cidade()
        {
            try
            {
                clBanco.Conectar();
                MySqlCommand sql = new MySqlCommand("SELECT nome FROM cidade WHERE id = '" + clEmpresa.Cidade_id + "';", clBanco.Conn);
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
                MySqlCommand sql = new MySqlCommand("SELECT nome FROM estado WHERE id = '" + clEmpresa.Estado_id + "';", clBanco.Conn);
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

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o registro?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (resultado == DialogResult.OK)
            {
                clEmpresa.Inativar();
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
