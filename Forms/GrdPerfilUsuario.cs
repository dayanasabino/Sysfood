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
    public partial class GrdPerfilUsuario : Form
    {
        public GrdPerfilUsuario()
        {
            InitializeComponent();
        }

        public static string opcaostatusperfil;

        Classes.PerfilUsuario clPerfil = new Classes.PerfilUsuario();

        private void GrdPerfilUsuario_Load(object sender, EventArgs e)
        {
            CmbStatus.SelectedIndex = 0;
            GridPerfilUsuario();
        }

        public void GridPerfilUsuario()
        {
            DGVPerfilUsuario.DataSource = clPerfil.Buscar();
        }

        private void CmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            opcaostatusperfil = CmbStatus.Text;
            GridPerfilUsuario();
        }

        private void DGVPerfilUsuario_DoubleClick(object sender, EventArgs e)
        {
            Classes.PerfilUsuario.Idperfil = Convert.ToInt32(DGVPerfilUsuario.CurrentRow.Cells[0].Value);
            this.DialogResult = DialogResult.OK;
        }
    }
}
