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
    public partial class GrdEmpresa : Form
    {
        public GrdEmpresa()
        {
            InitializeComponent();
        }

        public static string opcaostatus;
        public static int IdempresaR;

        Classes.Empresa clEmpresa = new Classes.Empresa();
        Classes.Banco clBanco = new Classes.Banco();

        private void GrdEmpresa_Load(object sender, EventArgs e)
        {
            CmbStatus.SelectedIndex = 0;
            GridEmpresa();
        }

        public void GridEmpresa()
        {
            DGVEmpresa.DataSource = clEmpresa.Buscar();
        }

        private void CmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            opcaostatus = CmbStatus.Text;
            GridEmpresa();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            clBanco.Conectar();
            string sql = "SELECT * FROM vEmpresa WHERE nomefantasia LIKE (@Nome) AND status IN ('" + Forms.GrdEmpresa.opcaostatus + "');";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, clBanco.Conn);
            da.SelectCommand.Parameters.AddWithValue("@Nome", "%" + textBox1.Text + "%");
            DataSet ds = new DataSet();
            da.Fill(ds, "Nome");
            DGVEmpresa.DataSource = ds.Tables["Nome"];
        }

        private void DGVEmpresa_DoubleClick(object sender, EventArgs e)
        {
            IdempresaR = Convert.ToInt32(DGVEmpresa.CurrentRow.Cells[0].Value);
            this.DialogResult = DialogResult.OK;
        }
    }
}
