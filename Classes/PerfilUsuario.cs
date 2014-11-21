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
    class PerfilUsuario
    {
        Classes.Banco clBanco = new Classes.Banco();

        public static int Idperfil;

        private int[] permissoes;
        public int[] Permissoes
        {
            get { return permissoes; }
            set { permissoes = value; }
        }

        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private int status;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        public string per;

        public void Gravar()
        {
            per = String.Concat(Permissoes[0], '|', Permissoes[1], '|', Permissoes[2], '|', Permissoes[3], '|', Permissoes[4], '|', Permissoes[5], '|', Permissoes[6], '|', Permissoes[7], '|', Permissoes[8], '|', Permissoes[9], '|', Permissoes[10]);
            string sql = "INSERT INTO PerfilUsuario (descricao, stringperfil, status) VALUES ('" + Descricao + "','" + per + "', " + 0 + ");";
            clBanco.Executar(sql);
        }

        public DataTable Buscar()
        {
            DataTable dt = new DataTable();
            try
            {
                clBanco.Conectar();
                MySqlCommand sql = new MySqlCommand("SELECT * FROM vPerfilUsuario WHERE status IN ('" + Forms.GrdPerfilUsuario.opcaostatusperfil + "');", clBanco.Conn);
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
            MySqlCommand sql = new MySqlCommand(";", clBanco.Conn);
            MySqlDataReader dr = sql.ExecuteReader();
            if (dr.Read())
            {
                Idperfil = Convert.ToInt32(dr["id"]);
                Descricao = dr["descricao"].ToString();
                string auxpermissao = dr["stringperfil"].ToString(); //Dividir em substring e jogar nos checkbox
                Status = Convert.ToInt32(dr["status"]);
            }

            return dr;
        }

        public void Editar()
        {
            try
            {
                per = String.Concat(Permissoes[0], '|', Permissoes[1], '|', Permissoes[2], '|', Permissoes[3], '|', Permissoes[4], '|', Permissoes[5], '|', Permissoes[6], '|', Permissoes[7], '|', Permissoes[8], '|', Permissoes[9], '|', Permissoes[10]);
            
                string sql = "UPDATE usuario SET empresa_id = '" + Classes.Usuario.idempresa +"', descricao = '" + Descricao + "', stringperfil = '" + per + "', status = '" + Status + "' WHERE id = '" + Idperfil + "'; ";
                clBanco.Executar(sql);

                DialogResult resultado = MessageBox.Show("Deseja Ativar ao salvar o cadastro?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    string sql2 = "UPDATE usuario SET status = 0 WHERE  id = '" + Idperfil + "';";
                    clBanco.Executar(sql2);
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
                string sql = "UPDATE perfilusuario SET status = 1 WHERE id = '" + Idperfil + "'";
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
