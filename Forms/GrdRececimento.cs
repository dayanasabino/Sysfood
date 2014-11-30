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
    public partial class GrdRecebimento : Form
    {
        public GrdRecebimento()
        {
            InitializeComponent();
        }

        public static string opcaostatus;
        Classes.Recebimento clRecebimento = new Classes.Recebimento();
        Classes.Banco clBanco = new Classes.Banco();


        private void GrdRecebimento_Load(object sender, EventArgs e)
        {
            CmbStatus.SelectedIndex = 0;
            GridRecebimento();
        }

        public void GridRecebimento()
        {
            DGVRecebimento.DataSource = clRecebimento.Buscar();
        }

        private void CmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            opcaostatus = CmbStatus.Text;
            GridRecebimento();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            clBanco.Conectar();
            string sql = "SELECT * FROM vRecebimento WHERE venda_id LIKE (@nota) AND status IN ('" + Forms.GrdRecebimento.opcaostatus + "');";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, clBanco.Conn);
            da.SelectCommand.Parameters.AddWithValue("@nota", "%" + textBox1.Text + "%");
            DataSet ds = new DataSet();
            da.Fill(ds, "nota");
            DGVRecebimento.DataSource = ds.Tables["nota"];
        }

        private void DGVRecebimento_DoubleClick(object sender, EventArgs e)
        {
            Classes.Recebimento.idrecebimento = Convert.ToInt32(DGVRecebimento.CurrentRow.Cells[0].Value);
            this.DialogResult = DialogResult.OK;
        }


    }
}
