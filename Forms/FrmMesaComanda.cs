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
            if (TxtMesaComanda.Text == "") // verifica se textbox está preenchido.
            {
                MessageBox.Show("Favor informar o número da Mesa/Comanda.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (!LtbMesaComanda.Items.Contains(TxtMesaComanda.Text)) // ! (contrário), verifica se item já consta pelo método contains, !contains - não contem 
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

        private void BtnInserirItens_Click(object sender, EventArgs e)
        {

            if (LtbMesaComanda.SelectedItem == null) // verifica se o item selecionado é nulo.
            {
                MessageBox.Show("Favor selecionar uma Mesa/Comanda.");
            }
            else
            {
                FrmTelaVenda telavenda = new FrmTelaVenda();
                telavenda.Show();
                string curItem = LtbMesaComanda.SelectedItem.ToString();
                //curitem é o numero da mesa ou comanda
            }

        }
    }
}
