using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; //referencia do mysql
using System.IO; //referencia de leitura de aquivos input output
using System.Data;
using System.Collections; //referencia que permite o uso de arrays
using System.Windows.Forms;

namespace SysFood.Classes
{
    class Banco
    {
        private string host;
        private string data;
        private string user;
        private string pass;
        private string port;
        private MySqlConnection conn;

        public MySqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }
        public string Host
        {
            get { return host; }
            set { host = value; }
        }
        public string Data
        {
            get { return data; }
            set { data = value; }
        }
        public string User
        {
            get { return user; }
            set { user = value; }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        public string Port
        {
            get { return port; }
            set { port = value; }
        }

        public static DataTable dt;
        public static MySqlDataReader dr;
        public static DataTable linha;

        public static string permissaoUsuario;

        public string AbrirArquivo()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Dayana Sabino\Desktop\TCC\SysFood\SysFood\conexao.ini"); //Indica o caminho de leitura do arquivo.
            string linha = ""; //Armazenará as linhas do arraylist.
            ArrayList arr = new ArrayList(); //Cria o arraylist.
            while (linha != null) //Executa o laço até linha ser difernte de nulo.
            {
                linha = sr.ReadLine(); //Faz a leitura linha por linha.
                if (linha != null)
                {
                    linha = linha.Substring(linha.IndexOf("=") + 1).Trim(); //Vai usar somente o que for lido apos "=" e trim elimina os espaços em branco.
                    arr.Add(linha); //Nesta parte que o valor formatado é atribuído a uma posição do array.
                }
            }
            //Nesta etapa a cada variável é atribuído a posição do array seu respectivo valor.
            this.Host = (string)arr[0];
            this.User = (string)arr[1];
            this.Pass = (string)arr[2];
            this.Data = (string)arr[3];
            this.Port = (string)arr[4];

            sr.Close(); //Fecha a leitura de arquivos.
            return linha; //Retorno.
        }

        public MySqlConnection Conectar()
        {
            try
            {
                AbrirArquivo(); //Chama o método e tenta abrir o arquivo.
                string conexao = ("Persist Security Info=False;server=" + this.host + ";database=" + this.data + ";uid=" + this.user + ";password=" + this.pass);
                conn = new MySqlConnection(conexao);
                conn.Open(); //Abre a conexão.

                if (conn.State == ConnectionState.Open)
                {
                    //MessageBox.Show("Você está conectado!");
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Problemas na abertura da base de dados. Favor verificar se a base existe ou se uma instância do MySQL está em execução.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }

        public void Executar(string sql)
        {
            try
            {
                Conectar();
                MySqlCommand execute = new MySqlCommand(sql, conn);
                execute.ExecuteNonQuery(); //Responsável por executar os comandos sql.
            }
            catch (Exception erro)
            {
                MessageBox.Show(""+erro);
                Application.Exit();
            }
        }

        public void FecharConexao()
        {
            try
            {
                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(""+error);
            }
        }

        public DataTable Estado()
        {
            Conectar();
            MySqlCommand com = new MySqlCommand();
            com.Connection = conn;
            com.CommandText = "SELECT id, sigla, nome FROM estado ORDER BY nome";
            dr = com.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            return dt;        
        }

        public DataTable ItensComanda()
        {
            Conectar();
            MySqlCommand com = new MySqlCommand();
            com.Connection = conn;
            com.CommandText = "select * from atendimento_mesacomanda_item";
            dr = com.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            return dt;
        }

        public DataTable Comanda()
        {
            Conectar();
            MySqlCommand com = new MySqlCommand();
            com.Connection = conn;
            com.CommandText = "select * from atendimento_mesacomanda";
            dr = com.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            return dt;
        }

        public DataTable Cidade(int id_estado)
        {
            Conectar();
            MySqlCommand com = new MySqlCommand();
            com.Connection = conn;
            com.CommandText = "SELECT cidade.id, cidade.nome FROM cidade INNER JOIN estado ON cidade.estado_id = estado.id WHERE estado.id = '" + id_estado + "' ";
            dr = com.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            return dt;
        }

        //Povoa combobox de perfil.
        public DataTable Perfil()
        {
            Conectar();
            MySqlCommand com = new MySqlCommand();
            com.Connection = conn;
            com.CommandText = "SELECT id, descricao, stringperfil, status FROM PerfilUsuario WHERE status = 0";
            dr = com.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            return dt;
        }

        //Povoa combobox de login.
        public DataTable Login()
        {
            Conectar();
            MySqlCommand com = new MySqlCommand();
            com.Connection = conn;
            com.CommandText = "SELECT usuario.id, usuario.login, usuario.senha,usuario.status, perfilusuario.stringperfil as permissao FROM Usuario inner join perfilusuario on usuario.perfilusuario_id = perfilusuario.id WHERE usuario.status = 0 ";
            dr = com.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            return dt;
        }

        public bool ConfereLogin(string login)
        {
            Conectar();
            MySqlCommand com = new MySqlCommand();
            com.Connection = conn;
            com.CommandText = "SELECT * FROM Usuario WHERE Login = '" + login + "'";

            if (com.ExecuteScalar() != null) // verifica se o sql retorna resultados
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable Grupo()
        {
            Conectar();
            MySqlCommand com = new MySqlCommand();
            com.Connection = conn;
            com.CommandText = "SELECT id, descricao, status FROM grupo WHERE status = 0";
            dr = com.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            return dt;
        }

        public DataTable Cliente()
        {
            Conectar();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = conn;
            comm.CommandText = "SELECT id, nome, endereco, bairro, numero, telefone FROM cliente WHERE status = 0";
            dr = comm.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            return dt;
        }

        public DataTable Mercadoria()
        {
            Conectar();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = conn;
            comm.CommandText = "SELECT id, codigodebarras, descricao, precovenda FROM mercadoria WHERE status = 0";
            dr = comm.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            return dt;
        }

        public int runQueryFetchId(string sql)
        {
            Conectar();
            MySqlCommand query = new MySqlCommand(sql, conn);
            query.ExecuteNonQuery();

            string lastId = "SELECT LAST_INSERT_ID() as id;";
            int id = 0;

            MySqlCommand command = new MySqlCommand(lastId, conn);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["id"]);
                }
            }

            else
            {
                id = 0;
            }

            reader.Close();
            return id;
        }

        public DataTable Finalizadoras()
        {
            Conectar();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = conn;
            comm.CommandText = "SELECT id, descricao, gerafinanceiro, geraparcelas FROM formapagamento WHERE status = 0";
            dr = comm.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            return dt;
        }
    }
}
