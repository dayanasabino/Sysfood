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
    public partial class GrdFormaPagamento : Form
    {
        public GrdFormaPagamento()
        {
            InitializeComponent();
        }

        public static string opcaostatus;
        Classes.FormaPagamento clPagamento = new Classes.FormaPagamento();
        Classes.Banco clBanco = new Classes.Banco();

        private void GrdFormaPagamento_Load(object sender, EventArgs e)
        {
            CmbStatus.SelectedIndex = 0;
            GridPagamento();
        }

        public void GridPagamento()
        {
            DGVPagamento.DataSource = clPagamento.Buscar();
        }

        private void CmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            opcaostatus = CmbStatus.Text;
            GridPagamento();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            clBanco.Conectar();
            string sql = "SELECT * FROM vPagamento WHERE descricao LIKE (@Descricao) AND status IN ('" + Forms.GrdFormaPagamento.opcaostatus + "');";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, clBanco.Conn);
            da.SelectCommand.Parameters.AddWithValue("@Descricao", "%" + textBox1.Text + "%");
            DataSet ds = new DataSet();
            da.Fill(ds, "Descricao");
            DGVPagamento.DataSource = ds.Tables["Descricao"];
        }

        private void DGVPagamento_DoubleClick(object sender, EventArgs e)
        {
            Classes.FormaPagamento.idpagamento = Convert.ToInt32(DGVPagamento.CurrentRow.Cells[0].Value);
            this.DialogResult = DialogResult.OK;
        }

    }
}
