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
    class Mercadoria
    {
        public static int idmercadoria;

        private string datacadastro;
        public string Datacadastro
        {
            get { return datacadastro; }
            set { datacadastro = value; }
        }

        private int codigodebarras;
        public int Codigodebarras
        {
            get { return codigodebarras; }
            set { codigodebarras = value; }
        }

        private int grupo_id;
        public int Grupo_id
        {
            get { return grupo_id; }
            set { grupo_id = value; }
        }

        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private decimal precocusto;
        public decimal Precocusto
        {
            get { return precocusto; }
            set { precocusto = value; }
        }

        private decimal precovenda;
        public decimal Precovenda
        {
            get { return precovenda; }
            set { precovenda = value; }
        }

        private decimal estoque;
        public decimal Estoque
        {
            get { return estoque; }
            set { estoque = value; }
        }

        private string tipoitem;
        public string Tipoitem
        {
            get { return tipoitem; }
            set { tipoitem = value; }
        }

        private string unidade;
        public string Unidade
        {
            get { return unidade; }
            set { unidade = value; }
        }

        private int validade;
        public int Validade
        {
            get { return validade; }
            set { validade = value; }
        }

        private string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
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

        Classes.Banco clBanco = new Classes.Banco();

        public void Salvar()
        {
            string sql = "INSERT INTO mercadoria(empresa_id, datacadastro, codigodebarras, grupo_id ,descricao, precocusto, "+
                         "precovenda, estoque, tipoitem, unidade, validade, marca, observacao, status) VALUES " +
                         "('" + 2 + "', '" + Datacadastro + "', '" + Codigodebarras + "', '" + Grupo_id + "', '" + Descricao + "'"+
                         ", REPLACE('" + Precocusto + "', ',', '.'), REPLACE('" + Precovenda + "', ',', '.'), REPLACE('" + Estoque + "', ',', '.'), '" + Tipoitem + "', '" + Unidade + "'" +
                         ", '" + Validade + "', '" + Marca + "', '" + Observacao + "', '" + Status + "')";
            clBanco.Executar(sql);
        }

        public DataTable Buscar()
        {
            DataTable dt = new DataTable();
            try
            {
                clBanco.Conectar();
                MySqlCommand sql = new MySqlCommand("SELECT * FROM vMercadoria WHERE status IN ('" + Forms.GrdMercadoria.opcaostatus + "');", clBanco.Conn);
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
            MySqlCommand sql = new MySqlCommand("SELECT * FROM vretornomercadoria WHERE id = '" + idmercadoria + "';", clBanco.Conn);
            MySqlDataReader dr = sql.ExecuteReader();
            if (dr.Read())
            {
                //Idempresa = Convert.ToInt32(dr["id"]);
                Datacadastro = dr["datacadastro"].ToString();
                codigodebarras = Convert.ToInt32(dr["codigodebarras"]);
                grupo_id = Convert.ToInt32(dr["grupo_id"]);
                Descricao = dr["descricao"].ToString();
                precocusto = Convert.ToDecimal(dr["precocusto"]);
                precovenda = Convert.ToDecimal(dr["precovenda"]);
                estoque = Convert.ToDecimal(dr["estoque"]);
                tipoitem = dr["tipoitem"].ToString();
                unidade = dr["unidade"].ToString();
                validade = Convert.ToInt32(dr["validade"]);
                marca = dr["marca"].ToString();
                observacao = dr["observacao"].ToString();
                Status = Convert.ToInt32(dr["status"]);
            }
            return dr;
        }

        public void Editar()
        {
            try
            {
                string sql = "UPDATE mercadoria SET datacadastro = '" + Datacadastro + "', codigodebarras = '" + Codigodebarras + "' "+
                             " , grupo_id = '" + Grupo_id + "', descricao = '" + Descricao + "', precocusto = REPLACE('" + Precocusto + "', ',', '.') " +
                             " , precovenda = REPLACE('" + Precovenda + "', ',', '.'), estoque = REPLACE('" + Estoque + "', ',', '.'), tipoitem = '" + Tipoitem + "' " +
                             " , unidade = '" + Unidade + "', validade = '" + Validade + "', marca = '" + Marca + "', observacao = '" + Observacao + "' "+
                             " , status = '" + Status + "' WHERE id = '" + idmercadoria + "'; ";
                clBanco.Executar(sql);

                if (Status == 1)
                {

                    DialogResult resultado = MessageBox.Show("Deseja Ativar ao salvar o cadastro?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resultado == DialogResult.OK)
                    {
                        string sql2 = "UPDATE mercadoria SET status = 0 WHERE  id = '" + idmercadoria + "';";
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
                string sql = "UPDATE mercadoria SET status = 1 WHERE id = '" + idmercadoria + "'";
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
