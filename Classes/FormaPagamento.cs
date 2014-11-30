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
    class FormaPagamento
    {
        public static int idpagamento;

        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private string datacadastro;
        public string Datacadastro
        {
            get { return datacadastro; }
            set { datacadastro = value; }
        }

        private int status;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        private int financeiro;
        public int Financeiro
        {
            get { return financeiro; }
            set { financeiro = value; }
        }

        private int parcelas;

        public int Parcelas
        {
            get { return parcelas; }
            set { parcelas = value; }
        }

        Classes.Banco clBanco = new Classes.Banco();

        public void Salvar()
        {
            string sql = "INSERT INTO formapagamento (empresa_id, descricao, datacadastro, gerafinanceiro, geraparcelas, status) VALUES " +
                         "('" + 2 + "', '" + Descricao + "', '" + Datacadastro + "', '" + Financeiro + "', '" + Parcelas + "','" + Status + "')";
            clBanco.Executar(sql);
        }

        public DataTable Buscar()
        {
            DataTable dt = new DataTable();
            try
            {
                clBanco.Conectar();
                MySqlCommand sql = new MySqlCommand("SELECT * FROM vPagamento WHERE status IN ('" + Forms.GrdFormaPagamento.opcaostatus + "');", clBanco.Conn);
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
            MySqlCommand sql = new MySqlCommand("SELECT * FROM vretornopagamento WHERE id = '" + idpagamento + "';", clBanco.Conn);
            MySqlDataReader dr = sql.ExecuteReader();
            if (dr.Read())
            {
                //Idempresa = Convert.ToInt32(dr["id"]);
                Datacadastro = dr["datacadastro"].ToString();
                Descricao = dr["descricao"].ToString();
                Financeiro = Convert.ToInt32(dr["gerafinanceiro"]);
                Parcelas = Convert.ToInt32(dr["geraparcelas"]);
                Status = Convert.ToInt32(dr["status"]);
            }
            return dr;
        }

        public void Editar()
        {
            try
            {
                string sql = "UPDATE formapagamento SET descricao = '" + Descricao + "', datacadastro = '" + Datacadastro + "', gerafinanceiro = '" + Financeiro + "', geraparcelas = '" + Parcelas + "',status = '" + Status + "' WHERE id = '" + idpagamento + "'; ";
                clBanco.Executar(sql);

                if (Status == 1)
                {

                    DialogResult resultado = MessageBox.Show("Deseja Ativar ao salvar o cadastro?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resultado == DialogResult.OK)
                    {
                        string sql2 = "UPDATE formapagamento SET status = 0 WHERE  id = '" + idpagamento + "';";
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
                string sql = "UPDATE formapagamento SET status = 1 WHERE id = '" + idpagamento + "'";
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
