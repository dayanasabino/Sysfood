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
    class AtendimentoMesaComanda
    {
        Classes.Banco clBanco = new Classes.Banco();

        //Variáveis Atendimento_MesaComanda
        public static int idamc;

        private string datacadastro;
        public string Datacadastro
        {
            get { return datacadastro; }
            set { datacadastro = value; }
        }

        private string mesacomanda;
        public string Mesacomanda
        {
            get { return mesacomanda; }
            set { mesacomanda = value; }
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

        //Variáveis Atendimento_MesaComandaItens
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

        //Variáveis Contas a Receber
        private int finalizadora;
        public int Finalizadora
        {
            get { return finalizadora; }
            set { finalizadora = value; }
        }

        private int parcelas;
        public int Parcelas
        {
            get { return parcelas; }
            set { parcelas = value; }
        }

        private string descfinalizadora;
        public string Descfinalizadora
        {
            get { return descfinalizadora; }
            set { descfinalizadora = value; }
        }

        private int cliente;
        public int Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        int aux;

        public void Salvar()
        {
            clBanco.Conectar();
            MySqlCommand busca = new MySqlCommand("SELECT * FROM atendimento_mesacomanda WHERE mesacomanda = '"+ Mesacomanda +"' AND aberta = 0;", clBanco.Conn);
            MySqlDataReader dr = busca.ExecuteReader();
            if (dr.Read())
            {
                aux = Convert.ToInt32(dr["id"]);
                string sql2 = "INSERT INTO `atendimento_mesacomanda_item` (`at_mesacomanda_id`, `codigodebarras`, `descricao`, `quantidade`, `precounitario`, `total`) " +
                "VALUES ('" + aux + "', '" + Barras + "', '" + Descricao + "', '" + Quantidade + "', REPLACE ('" + Precounitario + "', ',', '.'), REPLACE ('" + Totalgeral + "', ',', '.'));";

                clBanco.Executar(sql2);
            }
            //return dr;

            else
            {
                string sql = "INSERT INTO `atendimento_mesacomanda` (`datacadastro`, `mesacomanda`, `total`, `aberta`,`status`) " +
                    "VALUES ('" + Datacadastro + "', '" + Mesacomanda + "', '" + Total + "', '" + 0 + "','" + Status + "');";
                //passa aberta = 0 para indicar aberta e dar select sempre nas abertas ja que o número da comanda poderá
                //repetir e causar problemas na inserção dos itens

                aux = clBanco.runQueryFetchId(sql); // Executa a função junto ao comando acima.
                Forms.FrmFinalizadora.vendafinalizadora = aux;

                string sql2 = "INSERT INTO `atendimento_mesacomanda_item` (`at_mesacomanda_id`, `codigodebarras`, `descricao`, `quantidade`, `precounitario`, `total`) " +
                    "VALUES ('" + aux + "', '" + Barras + "', '" + Descricao + "', '" + Quantidade + "', REPLACE ('" + Precounitario + "', ',', '.'), REPLACE ('" + Totalgeral + "', ',', '.'));";

                clBanco.Executar(sql2);
            }
        }

        public DataTable Exibir()
        {
            DataTable dt = new DataTable();
            try
            {
                clBanco.Conectar();
                MySqlCommand sql = new MySqlCommand("SELECT * FROM vmesacomanda WHERE mesacomanda = '" + Mesacomanda + "' AND aberta = 0;", clBanco.Conn);
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

        public void Deletar(int delid)
        {
            try
            {
                string sql = "DELETE FROM atendimento_mesacomanda_item WHERE id = '" + delid  + "'";
                clBanco.Executar(sql);
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

        public MySqlDataReader Retornar()
        {
            clBanco.Conectar();
            MySqlCommand sql = new MySqlCommand("SELECT * FROM vmesacomanda WHERE mesacomanda = '" + Mesacomanda + "' AND aberta = 0;", clBanco.Conn);
            MySqlDataReader dr = sql.ExecuteReader();
            if (dr.Read())
            {
                Forms.FrmMesaComanda.iditem = Convert.ToInt32(dr["id"]);
                idamc = Convert.ToInt32(dr["cod"]);
            }
            return dr;
        }

        public void FecharVenda()
        {
            try
            {
                string sql = "UPDATE atendimento_mesacomanda SET aberta = 1 WHERE id = '" + idamc + "'";
                clBanco.Executar(sql);
                MessageBox.Show("Comanda/Mesa fechada com sucesso!", "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Erro ao fechar Mesa/Comanda.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                clBanco.FecharConexao();
            }
        }

        public void DeletarMesaComanda()
        {
            try
            {
                string sql = "DELETE FROM atendimento_mesacomanda WHERE id = '" + idamc + "'";
                clBanco.Executar(sql);
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

        public void GravarRecebimentos()
        {
            clBanco.Conectar();

            string sql = "INSERT INTO recebimentos (datacadastro, finalizadora, venda_id, cliente_id, descricao, quitado, total, parcelas, status)" +
                "VALUES ('" + Forms.FrmFinalizadoraMC.datafinalizadora + "', '" + Descfinalizadora + "', '" + idamc + "', '" + Cliente + "', 'Venda efetuada através do módulo Mesa/Comanda', '" + 1 + "', REPLACE ('" + Total + "', ',', '.'), '" + Parcelas + "','" + 0 + "')";
            clBanco.Executar(sql);

            //passar finalizadora :(
        }
    }
}
