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
    class Recebimento
    {
        public static int idrecebimento;

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

        private string finalizadora;
        public string Finalizadora
        {
            get { return finalizadora; }
            set { finalizadora = value; }
        }

        private int quitado;
        public int Quitado
        {
            get { return quitado; }
            set { quitado = value; }
        }

        private int parcelas;
        public int Parcelas
        {
            get { return parcelas; }
            set { parcelas = value; }
        }

        private decimal total;
        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        private int nVenda;
        public int NVenda
        {
            get { return nVenda; }
            set { nVenda = value; }
        }

        private int status;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        private int cliente;

        public int Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        Classes.Banco clBanco = new Classes.Banco();

        public void Salvar()
        {
            string sql = "INSERT INTO recebimentos(datacadastro, finalizadora, venda_id, cliente_id, descricao, quitado, parcelas, total, status) VALUES " +
                         "('" + Datacadastro + "', '" + Finalizadora + "', '" + NVenda + "', '" + Cliente + "', '" + Descricao + "', '" + Quitado + "', '" + Parcelas + "', REPLACE ('" + Total + "', ',', '.'),'" + Status + "')";
            clBanco.Executar(sql);
        }

        public DataTable Buscar()
        {
            DataTable dt = new DataTable();
            try
            {
                clBanco.Conectar();
                MySqlCommand sql = new MySqlCommand("SELECT * FROM vRecebimento WHERE status IN ('" + Forms.GrdRecebimento.opcaostatus + "');", clBanco.Conn);
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

        public void Inativar()
        {
            try
            {
                string sql = "UPDATE recebimentos SET status = 1 WHERE id = '" + idrecebimento + "'";
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

        public void Editar()
        {
            try
            {
                string sql = "UPDATE recebimentos SET quitado = '" + Quitado + "', status = '" + Status + "' WHERE id = '" + idrecebimento + "'; ";
                clBanco.Executar(sql);

                if (Status == 1)
                {

                    DialogResult resultado = MessageBox.Show("Deseja Ativar ao salvar o cadastro?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resultado == DialogResult.OK)
                    {
                        string sql2 = "UPDATE recebimentos SET status = 0 WHERE  id = '" + idrecebimento + "';";
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

        public MySqlDataReader Retornar()
        {
            clBanco.Conectar();
            MySqlCommand sql = new MySqlCommand("SELECT * FROM vretornorecebimento WHERE id = '" + idrecebimento + "';", clBanco.Conn);
            MySqlDataReader dr = sql.ExecuteReader();
            if (dr.Read())
            {
                //Idempresa = Convert.ToInt32(dr["id"]);
                Datacadastro = dr["datacadastro"].ToString();
                Finalizadora = dr["finalizadora"].ToString();
                Cliente = Convert.ToInt32(dr["cliente_id"]);
                Quitado = Convert.ToInt32(dr["quitado"]);
                Parcelas = Convert.ToInt32(dr["parcelas"]);
                Total = Convert.ToDecimal(dr["total"]);
                NVenda = Convert.ToInt32(dr["venda_id"]);
                Descricao = dr["descricao"].ToString();
                Status = Convert.ToInt32(dr["status"]);
            }
            return dr;
        }
    }
}
