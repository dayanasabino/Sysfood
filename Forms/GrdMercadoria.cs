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
    public partial class GrdMercadoria : Form
    {
        public GrdMercadoria()
        {
            InitializeComponent();
        }

        public static string opcaostatus;
        Classes.Mercadoria clMercadoria = new Classes.Mercadoria();
        Classes.Banco clBanco = new Classes.Banco();

        private void GrdMercadoria_Load(object sender, EventArgs e)
        {
            CmbStatus.SelectedIndex = 0;
            GridMercadoria();
        }

        public void GridMercadoria()
        {
            DGVMercadoria.DataSource = clMercadoria.Buscar();
        }

        private void CmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            opcaostatus = CmbStatus.Text;
            GridMercadoria();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            clBanco.Conectar();
            string sql = "SELECT * FROM vMercadoria WHERE descricao LIKE (@Descricao) AND status IN ('" + Forms.GrdMercadoria.opcaostatus + "');";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, clBanco.Conn);
            da.SelectCommand.Parameters.AddWithValue("@Descricao", "%" + textBox1.Text + "%");
            DataSet ds = new DataSet();
            da.Fill(ds, "Descricao");
            DGVMercadoria.DataSource = ds.Tables["Descricao"];
        }

        private void DGVMercadoria_DoubleClick(object sender, EventArgs e)
        {
            Classes.Mercadoria.idmercadoria = Convert.ToInt32(DGVMercadoria.CurrentRow.Cells[0].Value);
            this.DialogResult = DialogResult.OK;
        }
    }
}
