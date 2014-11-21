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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();

        }

        // Bloco de variáveis.
        int id_estado;
        int id_perfil;

        //Bloco de instâncias de classe.
        Classes.Banco clBanco = new Classes.Banco();
        Classes.Usuario clUsuario = new Classes.Usuario();
        Classes.Conversao clConversao = new Classes.Conversao();
        Classes.Validacao clValidacao = new Classes.Validacao();

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CarregarEstado();
            CarregarPerfil();
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

        public void CarregarPerfil()
        {
            clBanco.Perfil();
            CmbTipoPerfil.DisplayMember = "descricao";
            CmbTipoPerfil.DataSource = Classes.Banco.dt;
        }

        private void CmbTipoPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbTipoPerfil.ValueMember = "id";
            id_perfil = Convert.ToInt32(CmbTipoPerfil.SelectedValue);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //idempresa
            clUsuario.Idperfilusuario = id_perfil;
            clUsuario.Datacadastro = clConversao.ConverterData(DtpDataCadastro.Text);
            clUsuario.Login = TxtLogin.Text;
            Classes.Usuario.Senha = TxtSenha.Text;
            Classes.Usuario.Repetirsenha = TxtRepetirSenha.Text;

            clValidacao.ValidarCpf(MtbCpf.Text);
            clValidacao.ExistenciaCpf(MtbCpf.Text);

            Classes.Validacao.retornovalidacao = true;
            Classes.Validacao.retornovalidacaoigualdade = false;

            if (Classes.Validacao.retornovalidacao == true)
            {
                if (Classes.Validacao.retornovalidacaoigualdade == false)
                {
                    // chamar e testar validação de senha existencia
                    clUsuario.Cpf = MtbCpf.Text;
                    clUsuario.Rg = TxtRg.Text;
                    clUsuario.Nome = TxtNome.Text;

                    if (CmbSexo.Text == "Feminino") { clUsuario.Sexo = 0; }
                    if (CmbSexo.Text == "Masculino") { clUsuario.Sexo = 1; }

                    clUsuario.Datanascimento = clConversao.ConverterData(DtpDatanascimento.Text);
                    clUsuario.Endereco = TxtEndereco.Text;
                    clUsuario.Bairro = TxtBairro.Text;
                    clUsuario.Numero = TxtNumero.Text;
                    clUsuario.Complemento = TxtComplemento.Text;
                    clUsuario.Cidade_id = Convert.ToInt32(CmbCidade.SelectedValue);
                    clUsuario.Estado_id = Convert.ToInt32(CmbEstado.SelectedValue);
                    clUsuario.Cep = MtbCep.Text;
                    clUsuario.Telefone = MtbTelefone.Text;
                    clUsuario.Celular = MtbCelular.Text;
                    clUsuario.Email = TxtEmail.Text;
                    clUsuario.Observacao = TxtObservacao.Text;

                    if (CkbStatus.Checked == true) { clUsuario.Status = 0; }
                    if (CkbStatus.Checked == false) { clUsuario.Status = 1; }


                    if (TxtCodigo.Text == "")
                    {
                        Classes.Usuario.tipousuario = false;
                        try
                        {
                            clUsuario.Salvar();
                            Limpar(this);
                            MessageBox.Show("Dados gravados com sucesso!", "Confirmação.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show("Não foi possível gravar os dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                                                
                    }
                    else
                    {
                        Classes.Usuario.tipousuario = true;
                        try
                        {
                            clUsuario.Editar();
                            MessageBox.Show("Dados editados com sucesso!", "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpar(this);
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show("Não foi salvar as alterações.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("CPF existente.");
                }
            }
            else
            {
                MessageBox.Show("Favor informar um CPF válido.");
            }

        }

        public void Limpar(Form frm) //aqui voce seta o focus.
        {
            foreach (Control item in frm.Controls)
            {
                if (item is TabControl)
                {
                    foreach (TabPage page in ((TabControl)item).TabPages)
                    {
                        foreach (Control control in page.Controls)
                        {
                            if (control is TextBox)
                                control.Text = "";

                            if (control is MaskedTextBox)
                                control.Text = "";

                            if (control is DateTimePicker)
                                control.Text = "";
                        }
                    }
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpar(this);

            if (MessageBox.Show("Deseja fechar a janela?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Forms.GrdUsuario grUsuario = new Forms.GrdUsuario();
            //grUsuario.Show();

            if (grUsuario.ShowDialog() == DialogResult.OK)
            {
                clUsuario.Retornar();
                TxtCodigo.Text = Classes.Usuario.idusuario.ToString();
                /*Idperfilusuario = Convert.ToInt32(dr["perfilusuario_id"]);*/
                tipoperfil();
                DtpDataCadastro.Text = clUsuario.Datacadastro;
                TxtLogin.Text = clUsuario.Login;
                MtbCpf.Text = clUsuario.Cpf;
                TxtRg.Text = clUsuario.Rg;
                TxtNome.Text = clUsuario.Nome;
                if( clUsuario.Sexo == 0 ) { CmbSexo.SelectedIndex = 0; }
                if( clUsuario.Sexo == 1 ) { CmbSexo.SelectedIndex = 1; }
                DtpDatanascimento.Text = clUsuario.Datanascimento;
                TxtEndereco.Text = clUsuario.Endereco;
                TxtBairro.Text = clUsuario.Bairro;
                TxtNumero.Text = clUsuario.Numero;
                TxtComplemento.Text = clUsuario.Complemento;
                estado();
                cidade();
                MtbCep.Text = clUsuario.Cep;
                MtbTelefone.Text = clUsuario.Telefone;
                MtbCelular.Text = clUsuario.Celular;
                TxtEmail.Text = clUsuario.Email;
                TxtObservacao.Text = clUsuario.Observacao;
                if (clUsuario.Status == 0) { CkbStatus.Checked = true; }
                if (clUsuario.Status == 1) { CkbStatus.Checked = false; }
            }
        }

        public void cidade()
        {
            try
            {
                clBanco.Conectar();
                MySqlCommand sql = new MySqlCommand("SELECT nome FROM cidade WHERE id = '" + clUsuario.Cidade_id + "';", clBanco.Conn);
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
                MySqlCommand sql = new MySqlCommand("SELECT nome FROM estado WHERE id = '" + clUsuario.Estado_id + "';", clBanco.Conn);
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

        public void tipoperfil()
        {
            try
            {
                clBanco.Conectar();
                MySqlCommand sql = new MySqlCommand("SELECT descricao FROM perfilusuario WHERE id = '" + clUsuario.Idperfilusuario + "';", clBanco.Conn);
                MySqlDataReader dr = sql.ExecuteReader();
                if (dr.Read())
                {
                    CmbTipoPerfil.Text = dr["descricao"].ToString();
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
                clUsuario.Inativar();
                Limpar(this);
            }
        }

    }
}
