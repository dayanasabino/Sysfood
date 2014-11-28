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
    class AtendimentoTelefonico
    {
        Classes.Banco clBanco = new Classes.Banco();

        public static int idatt;

        private string datacadastro;
        public string Datacadastro
        {
            get { return datacadastro; }
            set { datacadastro = value; }
        }

        private int cliente;
        public int Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        private decimal desconto;
        public decimal Desconto
        {
            get { return desconto; }
            set { desconto = value; }
        }

        private decimal acrescimo;
        public decimal Acrescimo
        {
            get { return acrescimo; }
            set { acrescimo = value; }
        }

        private decimal subtotal;
        public decimal Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        private decimal total;
        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        private int status;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        private int barras;
        public int Barras
        {
            get { return barras; }
            set { barras = value; }
        }

        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private decimal quantidade;
        public decimal Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        private decimal precounitario;
        public decimal Precounitario
        {
            get { return precounitario; }
            set { precounitario = value; }
        }

        private decimal totalgeral;
        public decimal Totalgeral
        {
            get { return totalgeral; }
            set { totalgeral = value; }
        }

        int aux;

        public void GravarAtendimento()
        {
            clBanco.Conectar();

            string sql = "INSERT INTO atendimento_telefonico (datacadastro, cliente_id, acrescimo, desconto, subtotal, total, status) "+
                "VALUES ('" + Datacadastro + "', '" + Cliente + "', REPLACE ('" + Acrescimo + "', ',', '.'), REPLACE ('" + Desconto + "', ',', '.'), REPLACE ('" + Subtotal + "', ',', '.'), REPLACE ('" + Total + "', ',', '.'), '" + Status + "')";

            aux = clBanco.runQueryFetchId(sql); // Executa a função junto ao comando acima.
        }

        public void GravarAtendimentoItem()
        {
            string sql = "INSERT INTO atendimento_telefonico_item (at_tel_id, codigodebarras, descricao, quantidade, precounitario, total)" +
                "VALUES ('" + aux + "', @barras, @descricao, @qtd, @unitario, @total)";

            var cmd = new MySqlCommand(sql, clBanco.Conn);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@barras", Barras);
            cmd.Parameters.AddWithValue("@descricao", Descricao );
            cmd.Parameters.AddWithValue("@qtd", Quantidade);
            cmd.Parameters.AddWithValue("@unitario", Precounitario);
            cmd.Parameters.AddWithValue("@total", Totalgeral);

            cmd.ExecuteNonQuery();
        }

        public DataTable Buscar()
        {
            DataTable dt = new DataTable();
            try
            {
                clBanco.Conectar();
                MySqlCommand sql = new MySqlCommand("SELECT * FROM vgridvendatel WHERE status IN ('" + Forms.GrdAtendimentoTelefonico.opcaostatus + "');", clBanco.Conn);
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
            MySqlCommand sql = new MySqlCommand("SELECT * FROM atendimento_telefonico WHERE id = '" + idatt + "';", clBanco.Conn);
            MySqlDataReader dr = sql.ExecuteReader();
            if (dr.Read())
            {
                Datacadastro = dr["datacadastro"].ToString();
                Cliente = Convert.ToInt32(dr["cliente_id"]);
                Acrescimo = Convert.ToDecimal(dr["acrescimo"]);
                Desconto = Convert.ToDecimal(dr["Desconto"]);
                Subtotal = Convert.ToDecimal(dr["subtotal"]);
                Total = Convert.ToDecimal(dr["total"]);
                Status = Convert.ToInt32(dr["status"]);
            }
            return dr;
        }

        public void Inativar()
        {
            try
            {
                string sql = "UPDATE atendimento_telefonico SET status = 1 WHERE id = '" + idatt + "'";
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

        public DataTable RetornoItens() // Povoa grid de itens da venda
        {
            DataTable dt = new DataTable();
            try
            {
                clBanco.Conectar();
                MySqlCommand sql = new MySqlCommand("SELECT at_tel_id AS CODIGO, codigodebarras AS BARRAS, descricao AS DESCRICAO, quantidade AS QUANTIDADE, precounitario AS UNITARIO, total AS TOTAL FROM atendimento_telefonico_item WHERE at_tel_id = '" + idatt + "';", clBanco.Conn);
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
    }
}
