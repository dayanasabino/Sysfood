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
    public partial class FrmMesaComanda : Form
    {
        public FrmMesaComanda()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (!LtbMesaComanda.Items.Contains(TxtMesaComanda.Text))
            {
                LtbMesaComanda.Items.Add(TxtMesaComanda.Text);
                TxtMesaComanda.Clear();
            }
            else
            {
                MessageBox.Show("Mesa/Comanda já aberta.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
