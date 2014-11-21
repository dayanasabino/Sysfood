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
    public partial class GrdGrupo : Form
    {
        public GrdGrupo()
        {
            InitializeComponent();
        }

        public static string opcaostatus;
        Classes.Grupo clGrupo = new Classes.Grupo();
        Classes.Banco clBanco = new Classes.Banco();

        private void GrdGrupo_Load(object sender, EventArgs e)
        {
            CmbStatus.SelectedIndex = 0;
            GridGrupo();
        }

        public void GridGrupo()
        {
            DGVGrupo.DataSource = clGrupo.Buscar();
        }

        private void CmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            opcaostatus = CmbStatus.Text;
            GridGrupo();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            clBanco.Conectar();
            string sql = "SELECT * FROM vGrupo WHERE descricao LIKE (@Descricao) AND status IN ('" + Forms.GrdGrupo.opcaostatus + "');";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, clBanco.Conn);
            da.SelectCommand.Parameters.AddWithValue("@Descricao", "%" + textBox1.Text + "%");
            DataSet ds = new DataSet();
            da.Fill(ds, "Descricao");
            DGVGrupo.DataSource = ds.Tables["Descricao"];
        }

        private void DGVGrupo_DoubleClick(object sender, EventArgs e)
        {
            Classes.Grupo.idgrupo = Convert.ToInt32(DGVGrupo.CurrentRow.Cells[0].Value);
            this.DialogResult = DialogResult.OK;
        }
    }
}
