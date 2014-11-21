using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysFood.Forms
{
    public partial class GrdCliente : Form
    {
        public GrdCliente()
        {
            InitializeComponent();
        }

        public static string opcaostatus;
        Classes.Cliente clCliente = new Classes.Cliente();
        Classes.Banco clBanco = new Classes.Banco();

        private void GrdCliente_Load(object sender, EventArgs e)
        {
            CmbStatus.SelectedIndex = 0;
            GridCliente();
        }

        public void GridCliente()
        {
            DGVCliente.DataSource = clCliente.Buscar();
        }

        private void CmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            opcaostatus = CmbStatus.Text;
            GridCliente();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            clBanco.Conectar();
            string sql = "SELECT * FROM vCliente WHERE nome LIKE (@Nome) AND status IN ('" + Forms.GrdCliente.opcaostatus + "');";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, clBanco.Conn);
            da.SelectCommand.Parameters.AddWithValue("@Nome", "%" + textBox1.Text + "%");
            DataSet ds = new DataSet();
            da.Fill(ds, "Nome");
            DGVCliente.DataSource = ds.Tables["Nome"];
        }

        private void DGVCliente_DoubleClick(object sender, EventArgs e)
        {
            Classes.Cliente.idcliente = Convert.ToInt32(DGVCliente.CurrentRow.Cells[0].Value);
            this.DialogResult = DialogResult.OK;
        }
    }
}
