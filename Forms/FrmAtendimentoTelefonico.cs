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
    public partial class FrmAtendimentoTelefonico : Form
    {
        public FrmAtendimentoTelefonico()
        {
            InitializeComponent();
        }

        Classes.Banco clBanco = new Classes.Banco();
        Classes.Mercadoria clMercadoria = new Classes.Mercadoria();
        Classes.Cliente clCliente = new Classes.Cliente();
        Classes.AtendimentoTelefonico clAtt = new Classes.AtendimentoTelefonico();
        Classes.Conversao clConversao = new Classes.Conversao();

        string varbarras;
        decimal somafinal;
        decimal acres;

        private void FrmAtendimentoTelefonico_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            CarregarCliente();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            BtnSalvar.Enabled = false;
            CarregarMercadoria();
            TxtQuantidade.Text = "1";//
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            BtnSalvar.Enabled = true;
            ItensGrid(); // Adiciona os itens na grid
            RecalculaValores();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            BtnSalvar.Enabled = true;
        }

        public void CarregarCliente()
        {
            clBanco.Cliente();
            CmbCliente.DisplayMember = "nome";
            CmbCliente.DataSource = Classes.Banco.dt;

            TxtEndereco.Text = ((DataRowView)CmbCliente.SelectedValue)["endereco"].ToString()
                +", "+ ((DataRowView)CmbCliente.SelectedValue)["numero"].ToString()
                +", "+ ((DataRowView)CmbCliente.SelectedValue)["bairro"].ToString();

            MtbTelefone.Text = ((DataRowView)CmbCliente.SelectedValue)["telefone"].ToString();
        }

        private void CmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtEndereco.Text = ((DataRowView)CmbCliente.SelectedValue)["endereco"].ToString()
               + ", " + ((DataRowView)CmbCliente.SelectedValue)["numero"].ToString()
               + ", " + ((DataRowView)CmbCliente.SelectedValue)["bairro"].ToString();

            MtbTelefone.Text = ((DataRowView)CmbCliente.SelectedValue)["telefone"].ToString();
        }

        public void CarregarMercadoria()
        {
            clBanco.Mercadoria();
            CmbMercadoria.DisplayMember = "descricao";
            CmbMercadoria.DataSource = Classes.Banco.dt;

            TxtValorUnitario.Text = ((DataRowView)CmbMercadoria.SelectedValue)["precovenda"].ToString();
            varbarras = ((DataRowView)CmbMercadoria.SelectedValue)["codigodebarras"].ToString();
        }

        private void CmbMercadoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtValorUnitario.Text = ((DataRowView)CmbMercadoria.SelectedValue)["precovenda"].ToString();
            SomaItem();
        }

        private void BtnBuscaProduto_Click(object sender, EventArgs e)
        {
            Forms.GrdMercadoria grMerc = new GrdMercadoria();
            if (grMerc.ShowDialog() == DialogResult.OK)
            {
                clMercadoria.Retornar();
                //TxtCodigo.Text = Classes.Mercadoria.idmercadoria.ToString();
                varbarras = clMercadoria.Codigodebarras.ToString();
                CmbMercadoria.Text = clMercadoria.Descricao;
                TxtValorUnitario.Text = clMercadoria.Precovenda.ToString();
            }
        }

        public void SomaItem()
        {
            decimal soma, qtd, vu;
            qtd = Convert.ToDecimal(TxtQuantidade.Text);
            vu = Convert.ToDecimal(TxtValorUnitario.Text);
            soma = qtd * vu;
            TxtTotalParcial.Text = soma.ToString();
        }

        private void TxtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (TxtQuantidade.Text != "")
            {
                SomaItem();
            }
        }

        private void BtnBuscaCliente_Click(object sender, EventArgs e)
        {
            Forms.GrdCliente grCliente = new Forms.GrdCliente();

            if (grCliente.ShowDialog() == DialogResult.OK)
            {
                clCliente.Retornar();
                //TxtCodigo.Text = Classes.Cliente.idcliente.ToString();
                CmbCliente.Text = clCliente.Nome;
                TxtEndereco.Text = clCliente.Endereco + 
                    ", " + clCliente.Numero + ", " + clCliente.Bairro;
                MtbTelefone.Text = clCliente.Telefone;
            }

        }

        public void ItensGrid()
        {
            //dataGridView1.Rows.Add(dataGridView1.RowCount, varbarras, CmbMercadoria.Text, TxtQuantidade.Text, TxtValorUnitario.Text, TxtTotalParcial.Text);
            dataGridView1.Rows.Add(varbarras, CmbMercadoria.Text, TxtQuantidade.Text, TxtValorUnitario.Text, TxtTotalParcial.Text);
        }

        public void RecalculaValores()
        {
            decimal total;

            decimal desc;
            decimal soma = Convert.ToDecimal(TxtTotalParcial.Text);

            if (TxtTotal.Text != "")
            {
                total = Convert.ToDecimal(TxtTotal.Text);
            }
            else
            {
                total = 0;
            }

            somafinal = total + soma;

            desc = Convert.ToDecimal(TxtDesconto.Text);

            TxtSubTotal.Text = somafinal.ToString();
            TxtTotal.Text = TxtSubTotal.Text;
        }

        private void TxtAcrescimo_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void Acrescimo()
        {
            decimal totalinicio, totalgeral;

            acres = Convert.ToDecimal(TxtAcrescimo.Text);
            totalinicio = Convert.ToDecimal(TxtTotal.Text);
            totalgeral = totalinicio + acres;
            decimal aux = System.Math.Round(totalgeral, 3);
            TxtTotal.Text = aux.ToString();
        }

        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {
            if (TxtAcrescimo.Text != "")
            {
                Acrescimo();
            }
            else
            {
                TxtAcrescimo.Text = "0";
                TxtTotal.Text = TxtTotalParcial.Text;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            CabecalhoVenda();

            clAtt.GravarAtendimento();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                clAtt.Barras = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                clAtt.Descricao = dataGridView1.Rows[i].Cells[1].Value.ToString();
                clAtt.Quantidade = Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value);
                clAtt.Precounitario = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                clAtt.Totalgeral = Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                clAtt.GravarAtendimentoItem();     
            }

            Forms.FrmFinalizadora.totalpagamento = clAtt.Total;
            Forms.FrmFinalizadora.datafinalizadora = clAtt.Datacadastro;
            Forms.FrmFinalizadora.clientefinalizadora = clAtt.Cliente;

            Forms.FrmFinalizadora finalizadora = new Forms.FrmFinalizadora();
            if (finalizadora.ShowDialog() == DialogResult.OK)
            {
                
            }

            MessageBox.Show("Dados gravados com sucesso!", "Gravar Dados.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
        }

        public void CabecalhoVenda()
        {
            clAtt.Datacadastro = clConversao.ConverterData(DtpDataCadastro.Text);
            clAtt.Cliente = Convert.ToInt32(((DataRowView)CmbCliente.SelectedValue)["id"]);
            clAtt.Acrescimo = Convert.ToDecimal(TxtAcrescimo.Text);
            clAtt.Desconto = Convert.ToDecimal(TxtDesconto.Text);
            clAtt.Subtotal = Convert.ToDecimal(TxtSubTotal.Text);
            clAtt.Total = Convert.ToDecimal(TxtTotal.Text);
            if (CkbStatus.Checked == true) { clAtt.Status = 0; }
            if (CkbStatus.Checked == false) { clAtt.Status = 1; }
        }

        private void BtnRemoverItens_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(this.dataGridView1.CurrentRow.Cells[0].RowIndex);
            //chamar função de calculo

            decimal soma = 0;

            foreach (DataGridViewRow dr in dataGridView1.Rows)
                soma += Convert.ToDecimal(dr.Cells[4].Value);

            TxtSubTotal.Text = Convert.ToString(soma);
            TxtTotal.Text = TxtSubTotal.Text;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Forms.GrdAtendimentoTelefonico grAtt = new Forms.GrdAtendimentoTelefonico();
            if (grAtt.ShowDialog() == DialogResult.OK)
            {
                clAtt.Retornar();
                
                TxtCodigo.Text = Classes.AtendimentoTelefonico.idatt.ToString();
                DtpDataCadastro.Text = clAtt.Datacadastro;
                CmbCliente.Text = clAtt.Cliente.ToString();
                TxtAcrescimo.Text = clAtt.Acrescimo.ToString();
                TxtDesconto.Text = clAtt.Desconto.ToString();
                TxtSubTotal.Text = clAtt.Subtotal.ToString();
                TxtTotal.Text = clAtt.Total.ToString();

                if (clAtt.Status == 0) { CkbStatus.Checked = true; }
                if (clAtt.Status == 1) { CkbStatus.Checked = false; }

                DataGridView datagridView1 = new DataGridView();
                BindingSource bindingSource1 = new BindingSource();

                datagridView1.AutoGenerateColumns = false;

                dataGridView1.DataSource = clAtt.RetornoItens();
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o registro?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (resultado == DialogResult.OK)
            {
                clAtt.Inativar();
                Limpar();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        public void Limpar()
        {
            foreach (Control c in this.Controls)
            {

                if (c is TextBox)
                    ((TextBox)c).Text = string.Empty;

                /*else if (c is CheckBox)
                    ((CheckBox)c).Checked = false;*/

                else if (c is MaskedTextBox)
                    ((MaskedTextBox)c).Text = string.Empty;

                else if (c is DateTimePicker)
                    ((DateTimePicker)c).Text = string.Empty;

                /*while (dataGridView1.Rows.Count >= 0)
                {
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                } */
            }

        }
    }
}
