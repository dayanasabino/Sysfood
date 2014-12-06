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

        public static int iditem; // id para exclusão de item

        string curItem;
        Classes.AtendimentoMesaComanda clMesaComanda = new Classes.AtendimentoMesaComanda();
        Classes.Conversao clConversao = new Classes.Conversao();

        public static string mesacomanda;
        public static string datacadastro;
        public static decimal total;
        public static int status;

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
                curItem = LtbMesaComanda.SelectedItem.ToString();
                //curItem é o numero da mesa ou comanda
            }
            mesacomanda = curItem;
            datacadastro = clConversao.ConverterData(DtpDataCadastro.Text);
            total = Convert.ToDecimal(TxtTotal.Text);
            if (CkbStatus.Checked == true) { status = 0; }
            if (CkbStatus.Checked == false) { status = 1; }

            /*Forms.FrmTelaVenda venda = new Forms.FrmTelaVenda();
            if (venda.ShowDialog() == DialogResult.OK)
            {
                clMesaComanda.Mesacomanda = LtbMesaComanda.SelectedItem.ToString();
                DGVMesaComanda.DataSource = clMesaComanda.Exibir();

            } - Atualizar grid automático */
        }

        private void LtbMesaComanda_DoubleClick(object sender, EventArgs e)
        {
            clMesaComanda.Mesacomanda = LtbMesaComanda.SelectedItem.ToString();
            DGVMesaComanda.DataSource = clMesaComanda.Exibir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o registro?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (resultado == DialogResult.OK)
            {
                clMesaComanda.Retornar();
                clMesaComanda.Deletar(iditem);
                DGVMesaComanda.Rows.RemoveAt(this.DGVMesaComanda.CurrentRow.Cells[0].RowIndex);
                //Limpar();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //excluir do banco antes!
            LtbMesaComanda.Items.RemoveAt(LtbMesaComanda.SelectedIndex);

            for (int i=0; i<=DGVMesaComanda.Rows.Count; i++)
            {
                clMesaComanda.Retornar();
                clMesaComanda.Deletar(iditem);
            }
            
            //deletar a tabela master
            //lentidão

            while (DGVMesaComanda.Rows.Count > 1)
            {
                DGVMesaComanda.Rows.RemoveAt(DGVMesaComanda.CurrentRow.Index);
            }
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            // update para pegar a comanda e mudar o aberto para = 1!
            clMesaComanda.FecharVenda();

            LtbMesaComanda.Items.RemoveAt(LtbMesaComanda.SelectedIndex);
            while (DGVMesaComanda.Rows.Count > 1)
            {
                DGVMesaComanda.Rows.RemoveAt(DGVMesaComanda.CurrentRow.Index);
            }
        }
    }
}
