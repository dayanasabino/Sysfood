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
    class Empresa
    {
        private int idempresa;
        public int Idempresa
        {
            get { return idempresa; }
            set { idempresa = value; }
        }

        private string datacadastro;
        public string Datacadastro
        {
            get { return datacadastro; }
            set { datacadastro = value; }
        }

        private string cnpj;
        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        private string ie;
        public string Ie
        {
            get { return ie; }
            set { ie = value; }
        }

        private string im;

        public string Im
        {
            get { return im; }
            set { im = value; }
        }

        private string cnae;
        public string Cnae
        {
            get { return cnae; }
            set { cnae = value; }
        }

        private string razaosocial;
        public string Razaosocial
        {
            get { return razaosocial; }
            set { razaosocial = value; }
        }

        private string nomefantasia;
        public string Nomefantasia
        {
            get { return nomefantasia; }
            set { nomefantasia = value; }
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

        private string fax;
        public string Fax
        {
            get { return fax; }
            set { fax = value; }
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

        public void Salvar()
        {
            string sql = "INSERT INTO empresa (id, datacadastro, cnpj, ie, im, cnae, razaosocial, nomefantasia, endereco, " +
                         "bairro, numero, complemento, cidade_id, estado_id, cep, telefone, fax, email, observacao, status) " +
                         "VALUES ('" + idempresa + "', '" + Datacadastro + "', '" + Cnpj + "', '" + Ie + "', '" + Im +"', "+
                         " '" + Cnae + "', '" + Razaosocial + "', '" + Nomefantasia + "', '" + Endereco + "', '" + Bairro +"', "+
                         " '" + Numero + "', '" + Complemento + "', '" + Cidade_id + "', '" + Estado_id + "', '" + Cep +"', "+
                         " '" + Telefone + "', '" + Fax + "', '" + Email + "', '" + Observacao +"', '" + Status + "')";
            clBanco.Executar(sql);
        }

        public DataTable Buscar()
        {
            DataTable dt = new DataTable();
            try
            {
                clBanco.Conectar();
                MySqlCommand sql = new MySqlCommand("SELECT * FROM vEmpresa WHERE status IN ('" + Forms.GrdEmpresa.opcaostatus + "');", clBanco.Conn);
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
            MySqlCommand sql = new MySqlCommand("SELECT * FROM vretornoempresa WHERE id = '" + Forms.GrdEmpresa.IdempresaR + "';", clBanco.Conn);
            MySqlDataReader dr = sql.ExecuteReader();
            if (dr.Read())
            {
                Idempresa = Convert.ToInt32(dr["id"]);
                Datacadastro = dr["datacadastro"].ToString();
                Cnpj = dr["cnpj"].ToString();
                Ie = dr["ie"].ToString();
                Im = dr["im"].ToString();
                Cnae = dr["cnae"].ToString();
                Razaosocial = dr["razaosocial"].ToString();
                Nomefantasia = dr["nomefantasia"].ToString();
                Endereco = dr["endereco"].ToString();
                Bairro = dr["bairro"].ToString();
                Numero = dr["numero"].ToString();
                Complemento = dr["complemento"].ToString();
                Cidade_id = Convert.ToInt32(dr["cidade_id"]);
                Estado_id = Convert.ToInt32(dr["estado_id"]);
                Cep = dr["cep"].ToString();
                Telefone = dr["telefone"].ToString();
                Fax = dr["fax"].ToString();
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
                string sql = "UPDATE empresa SET datacadastro = '" + Datacadastro + "', cnpj = '" + Cnpj + "', ie = '" + Ie + "', Im = '" + im + "',  " +
                    " cnae = '" + Cnae + "', razaosocial = '" + Razaosocial + "', nomefantasia = '" + Nomefantasia + "', endereco = '" + Endereco + "', " +
                    " bairro = '" + Bairro + "', numero = '" + Numero + "', complemento = '" + Complemento + "' ,  cidade_id = '" + Cidade_id + "', " +
                    " estado_id = '" + Estado_id + "', cep = '" + Cep + "', telefone = '" + Telefone + "', fax = '" + Fax + "', " +
                    " email = '" + Email + "', observacao = '" + Observacao + "', status = '" + Status + "' WHERE id = '" + Idempresa + "'; ";
                clBanco.Executar(sql);

                if (Status == 1)
                {
                    DialogResult resultado = MessageBox.Show("Deseja Ativar ao salvar o cadastro?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resultado == DialogResult.OK)
                    {
                        string sql2 = "UPDATE empresa SET status = 0 WHERE  id = '" + Idempresa + "';";
                        clBanco.Executar(sql2);
                    }
                }
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
                string sql = "UPDATE empresa SET status = 1 WHERE id = '" + Idempresa + "'";
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
