using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysFood.Classes
{
    class Usuario
    {
        //Bloco de variáveis estáticas.
        public static int idempresa; //deverá ir para a classe empresa quando a mesma for criada
        public static int idusuario;
        public static bool tipousuario; // 0 para novo; 1 para edição

        //Bloco de variáveis encapsuladas.
        private int idperfilusuario;
        public int Idperfilusuario
        {
            get { return idperfilusuario; }
            set { idperfilusuario = value; }
        }

        private string datacadastro;
        public string Datacadastro
        {
            get { return datacadastro; }
            set { datacadastro = value; }
        }

        private string login;
        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public static string Senha;
        public static string Repetirsenha;

        private string cpf;
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private string rg;
        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int sexo;
        public int Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private string datanascimento;
        public string Datanascimento
        {
            get { return datanascimento; }
            set { datanascimento = value; }
        }

        private string endereco;
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        private string bairro;
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        private string numero;
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private string complemento;
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        private int cidade_id;
        public int Cidade_id
        {
            get { return cidade_id; }
            set { cidade_id = value; }
        }

        private int estado_id;
        public int Estado_id
        {
            get { return estado_id; }
            set { estado_id = value; }
        }

        private string cep;
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        private string telefone;
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        private string celular;
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string observacao;
        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

        private int status;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        //Bloco de instâncias de classe.
        Classes.Banco clBanco = new Classes.Banco();
        Classes.Validacao clValidacao = new Classes.Validacao();
        Classes.Conversao clConversao = new Classes.Conversao();

        //Métodos.
        public void Salvar()
        {
            if (clBanco.ConfereLogin(Login) == false && Login != "")
            {
                if (clValidacao.ValidarIgualdadeSenha() == true && Senha != "")
                {
                    idempresa = 2;
                        string sql = "INSERT INTO Usuario (empresa_id, perfilusuario_id, datacadastro, login, senha," +
                        "cpf, rg, nome, sexo, datanascimento, endereco, bairro, numero, complemento, cidade_id, estado_id," +
                        "cep, telefone, celular, email, observacao, status) VALUES" +
                        "('" + idempresa + "', '" + Idperfilusuario + "', '" + Datacadastro + "', '" + Login + "'," +
                        "'" + Senha + "', '" + Cpf + "', '" + Rg + "', '" + Nome + "' ,'" + Sexo + "', '" + datanascimento + "'," +
                        "'" + Endereco + "', '" + Bairro + "', '" + Numero + "', '" + Complemento + "', '" + Cidade_id + "'," +
                        "'" + Estado_id + "', '" + Cep + "', '" + Telefone + "', '" + Celular + "', '" + Email + "'," +
                        "'" + Observacao + "', '" + Status + "')";
                        clBanco.Executar(sql);    
                    }
                
                else
                {
                    MessageBox.Show("Senhas incompatíveis. Verifique!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usuário já existe, favor informar um usuário válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable Buscar()
        {
            DataTable dt = new DataTable();
            try
            {
                clBanco.Conectar();
                MySqlCommand sql = new MySqlCommand("SELECT * FROM vUsuario WHERE status IN ('" + Forms.GrdUsuario.opcaostatus + "');", clBanco.Conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                da.Fill(dt);
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }
            finally
            {
                clBanco.FecharConexao();
            }
            return dt;
        }

        public MySqlDataReader Retornar()
        {
            clBanco.Conectar();
            MySqlCommand sql = new MySqlCommand("SELECT * FROM vretornousuario WHERE id = '" + Classes.Usuario.idusuario + "';", clBanco.Conn);
            MySqlDataReader dr = sql.ExecuteReader();
            if (dr.Read())
            {   
                Idperfilusuario = Convert.ToInt32(dr["perfilusuario_id"]);
                Datacadastro = dr["datacadastro"].ToString();
                Login = dr["login"].ToString();
                Cpf = dr["cpf"].ToString();
                Rg = dr["rg"].ToString();
                Nome = dr["nome"].ToString();
                Sexo = Convert.ToInt32(dr["sexo"]);
                Datanascimento = dr["datanascimento"].ToString();
                Endereco = dr["endereco"].ToString();
                Bairro = dr["bairro"].ToString();
                Numero = dr["numero"].ToString();
                Complemento = dr["complemento"].ToString();
                Cidade_id = Convert.ToInt32(dr["cidade_id"]);
                Estado_id = Convert.ToInt32(dr["estado_id"]);
                Cep = dr["cep"].ToString();
                Telefone = dr["telefone"].ToString();
                Celular = dr["celular"].ToString();
                Email = dr["email"].ToString();
                Observacao = dr["observacao"].ToString();
                Status = Convert.ToInt32(dr["status"]);
            }
            return dr;
        }

        public void Editar()
        {
            try
            {
                string sql = "UPDATE usuario SET empresa_id = '" + idempresa + "', perfilusuario_id = '" + Idperfilusuario + "', datacadastro = '" + Datacadastro + "', " +
                    " login = '" + Login + "', '" + Senha + "', cpf = '" + Cpf + "', rg = '" + Rg + "', nome = '" + Nome + "', sexo = '" + Sexo + "', " +
                    " datanascimento = '" + Datanascimento + "', endereco = '" + Endereco + "', bairro = '" + Bairro + "', numero = '" + Numero + "', complemento = '" + Complemento + "' , "+
                    " cidade_id = '" + Cidade_id + "', estado_id = '" + Estado_id + "', cep = '" + Cep + "', telefone = '" + Telefone + "', celular = '" + Celular + "', "+
                    " email = '" + Email + "', observacao = '" + Observacao + "', status = '" + Status + "' WHERE id = '" + idusuario + "'; ";
                clBanco.Executar(sql);
                
                DialogResult resultado = MessageBox.Show("Deseja Ativar ao salvar o cadastro?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    string sql2 = "UPDATE usuario SET status = 0 WHERE  id = '" + idusuario + "';";
                    clBanco.Executar(sql2);
                }

                //MessageBox.Show("Dados alterados com sucesso!", "Sucesso.", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Não foi possível atualizar os dados! Tente novamente. \nSe o erro persistir favor contatar seu suporte.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                clBanco.FecharConexao();
            }
        }

        public void Inativar()
        {
            try
            {
                string sql = "UPDATE usuario SET status = 1 WHERE id = '" + idusuario + "'";
                clBanco.Executar(sql);
                MessageBox.Show("Dados excluídos com sucesso!", "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Erro ao executar comando de exclusão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                clBanco.FecharConexao();
            }
        }
    }
}
