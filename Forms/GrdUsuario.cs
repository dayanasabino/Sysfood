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
    public partial class GrdUsuario : Form
    {
        public GrdUsuario()
        {
            InitializeComponent();
        }

        public static string opcaostatus;

        Classes.Usuario clUsuario = new Classes.Usuario();
        Classes.Banco clBanco = new Classes.Banco();

        private void GrdUsuario_Load(object sender, EventArgs e)
        {
            CmbStatus.SelectedIndex = 0;
            GridUsuario();
        }

        public void GridUsuario()
        {
            DGVUsuario.DataSource = clUsuario.Buscar();
        }

        private void CmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            opcaostatus = CmbStatus.Text;
            GridUsuario();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            clBanco.Conectar();
            string sql = "SELECT * FROM vUsuario WHERE nome LIKE (@Login) AND status IN ('" + Forms.GrdUsuario.opcaostatus + "');";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, clBanco.Conn);
            da.SelectCommand.Parameters.AddWithValue("@Login", "%" + textBox1.Text + "%");
            DataSet ds = new DataSet();
            da.Fill(ds, "Login");
            DGVUsuario.DataSource = ds.Tables["Login"];

        }

        private void DGVUsuario_DoubleClick(object sender, EventArgs e)
        {
            Classes.Usuario.idusuario = Convert.ToInt32(DGVUsuario.CurrentRow.Cells[0].Value);
            this.DialogResult = DialogResult.OK;
        }
    }
}
