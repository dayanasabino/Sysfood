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
    class Grupo
    {
        public static int idgrupo;

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

        Classes.Banco clBanco = new Classes.Banco();

        public void Salvar()
        {
            string sql = "INSERT INTO grupo(empresa_id, descricao, datacadastro, status) VALUES "+
                         "('" + 2 + "', '" + Descricao + "', '" + Datacadastro + "', '" + Status + "')";
            clBanco.Executar(sql);
        }

        public DataTable Buscar()
        {
            DataTable dt = new DataTable();
            try
            {
                clBanco.Conectar();
                MySqlCommand sql = new MySqlCommand("SELECT * FROM vGrupo WHERE status IN ('" + Forms.GrdGrupo.opcaostatus + "');", clBanco.Conn);
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
            MySqlCommand sql = new MySqlCommand("SELECT * FROM vretornogrupo WHERE id = '" + idgrupo + "';", clBanco.Conn);
            MySqlDataReader dr = sql.ExecuteReader();
            if (dr.Read())
            {
                //Idempresa = Convert.ToInt32(dr["id"]);
                Datacadastro = dr["datacadastro"].ToString();
                Descricao = dr["descricao"].ToString();
                Status = Convert.ToInt32(dr["status"]);
            }
            return dr;
        }

        public void Editar()
        {
            try
            {
                string sql = "UPDATE grupo SET descricao = '" + Descricao + "', datacadastro = '" + Datacadastro + "', status = '" + Status + "' WHERE id = '" + idgrupo + "'; ";
                clBanco.Executar(sql);

                if (Status == 1)
                {

                    DialogResult resultado = MessageBox.Show("Deseja Ativar ao salvar o cadastro?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resultado == DialogResult.OK)
                    {
                        string sql2 = "UPDATE grupo SET status = 0 WHERE  id = '" + idgrupo + "';";
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
                string sql = "UPDATE grupo SET status = 1 WHERE id = '" + idgrupo + "'";
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
