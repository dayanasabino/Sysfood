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
    class Cliente
    {
        public static int idcliente;

        public static int idempresa; 

        private string datacadastro;
        public string Datacadastro
        {
            get { return datacadastro; }
            set { datacadastro = value; }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string cpfcnpj;
        public string Cpfcnpj
        {
            get { return cpfcnpj; }
            set { cpfcnpj = value; }
        }

        private string rgie;
        public string Rgie
        {
            get { return rgie; }
            set { rgie = value; }
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
                idempresa = 2;
                string sql = "INSERT INTO cliente (empresa_id, datacadastro, nome," +
                "cpfcnpj, rgie, sexo, datanascimento, endereco, bairro, numero, complemento, cidade_id, estado_id," +
                "cep, telefone, fax, email, observacao, status) VALUES" +
                "('" + idempresa + "', '" + Datacadastro + "', '" + Nome + "'," +
                "'" + Cpfcnpj + "', '" + Rgie + "' ,'" + Sexo + "', '" + datanascimento + "'," +
                "'" + Endereco + "', '" + Bairro + "', '" + Numero + "', '" + Complemento + "', '" + Cidade_id + "'," +
                "'" + Estado_id + "', '" + Cep + "', '" + Telefone + "', '" + Celular + "', '" + Email + "'," +
                "'" + Observacao + "', '" + Status + "')";
                clBanco.Executar(sql);
        }

        public DataTable Buscar()
        {
            DataTable dt = new DataTable();
            try
            {
                clBanco.Conectar();
                MySqlCommand sql = new MySqlCommand("SELECT * FROM vCliente WHERE status IN ('" + Forms.GrdCliente.opcaostatus + "');", clBanco.Conn);
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
            MySqlCommand sql = new MySqlCommand("SELECT * FROM vretornocliente WHERE id = '" + Classes.Cliente.idcliente + "';", clBanco.Conn);
            MySqlDataReader dr = sql.ExecuteReader();
            if (dr.Read())
            {
                Datacadastro = dr["datacadastro"].ToString();
                Nome = dr["nome"].ToString();
                Cpfcnpj = dr["cpfcnpj"].ToString();
                Rgie = dr["rgie"].ToString();
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
                Celular = dr["fax"].ToString();
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
                idempresa = 2;
                string sql = "UPDATE cliente SET empresa_id = '" + idempresa + "', datacadastro = '" + Datacadastro + "', nome = '" + Nome + "', " +
                    " cpfcnpj = '" + Cpfcnpj + "', rgie = '" + Rgie + "', sexo = '" + Sexo + "', " +
                    " datanascimento = '" + Datanascimento + "', endereco = '" + Endereco + "', bairro = '" + Bairro + "', numero = '" + Numero + "', complemento = '" + Complemento + "' , " +
                    " cidade_id = '" + Cidade_id + "', estado_id = '" + Estado_id + "', cep = '" + Cep + "', telefone = '" + Telefone + "', fax = '" + Celular + "', " +
                    " email = '" + Email + "', observacao = '" + Observacao + "', status = '" + Status + "' WHERE id = '" + idcliente + "'; ";
                clBanco.Executar(sql);

                if (Status == 1)
                {
                    DialogResult resultado = MessageBox.Show("Deseja Ativar ao salvar o cadastro?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resultado == DialogResult.OK)
                    {
                        string sql2 = "UPDATE cliente SET status = 0 WHERE  id = '" + idcliente + "';";
                        clBanco.Executar(sql2);
                    }
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
                string sql = "UPDATE cliente SET status = 1 WHERE id = '" + idcliente + "'";
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
