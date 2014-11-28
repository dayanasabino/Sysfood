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
    public partial class GrdAtendimentoTelefonico : Form
    {
        public GrdAtendimentoTelefonico()
        {
            InitializeComponent();
        }

        public static string opcaostatus;
        Classes.AtendimentoTelefonico clAtt = new Classes.AtendimentoTelefonico();
        Classes.Banco clBanco = new Classes.Banco();

        private void GrdAtendimentoTelefonico_Load(object sender, EventArgs e)
        {
            CmbStatus.SelectedIndex = 0;
            GridAtendimentoTelefonico();
        }

        public void GridAtendimentoTelefonico()
        {
            DGVAtt.DataSource = clAtt.Buscar();
        }

        private void CmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            opcaostatus = CmbStatus.Text;
            GridAtendimentoTelefonico();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            clBanco.Conectar();
            string sql = "SELECT * FROM vgridvendatel WHERE cliente LIKE (@cliente) AND status IN ('" + Forms.GrdAtendimentoTelefonico.opcaostatus + "');";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, clBanco.Conn);
            da.SelectCommand.Parameters.AddWithValue("@cliente", "%" + textBox1.Text + "%");
            DataSet ds = new DataSet();
            da.Fill(ds, "cliente");
            DGVAtt.DataSource = ds.Tables["cliente"];
        }

        private void DGVAtt_DoubleClick(object sender, EventArgs e)
        {
            Classes.AtendimentoTelefonico.idatt = Convert.ToInt32(DGVAtt.CurrentRow.Cells[0].Value);
            this.DialogResult = DialogResult.OK;
        }
    }
}
