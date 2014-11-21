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
    public partial class FrmMercadoria : Form
    {
        public FrmMercadoria()
        {
            InitializeComponent();
        }

        public int id_grupo;

        Classes.Banco clBanco = new Classes.Banco();
        Classes.Mercadoria clMercadoria = new Classes.Mercadoria();
        Classes.Conversao clConversao = new Classes.Conversao();

        private void FrmMercadoria_Load(object sender, EventArgs e)
        {
            CmbTipoItem.SelectedIndex = 0;
            CarregarGrupo();
        }

        public void CarregarGrupo()
        {
            clBanco.Grupo();
            CmbGrupo.DisplayMember = "descricao";
            CmbGrupo.DataSource = Classes.Banco.dt;
        }

        public void Grupo()
        {
            try
            {
                clBanco.Conectar();
                MySqlCommand sql = new MySqlCommand("SELECT descricao FROM grupo WHERE id = '" + clMercadoria.Grupo_id + "';", clBanco.Conn);
                MySqlDataReader dr = sql.ExecuteReader();
                if (dr.Read())
                {
                    CmbGrupo.Text = dr["descricao"].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }
            finally
            {
                clBanco.FecharConexao();
            }
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
            }

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o registro?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (resultado == DialogResult.OK)
            {
                clMercadoria.Inativar();
                Limpar();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();

            if (MessageBox.Show("Deseja fechar a janela?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            clMercadoria.Datacadastro = clConversao.ConverterData(DtpDataCadastro.Text);
            clMercadoria.Codigodebarras = Convert.ToInt32(TxtCodigoBarras.Text);

            clMercadoria.Grupo_id = id_grupo;//Convert.ToInt32(CmbGrupo.SelectedValue);

            clMercadoria.Descricao = TxtDescricao.Text;
            clMercadoria.Precocusto = Convert.ToDecimal(TxtPrecoCusto.Text);
            clMercadoria.Precovenda = Convert.ToDecimal(TxtPrecoVenda.Text);
            clMercadoria.Estoque = Convert.ToDecimal(TxtEstoque.Text);
            clMercadoria.Tipoitem = CmbTipoItem.Text;
            clMercadoria.Unidade = TxtUnidade.Text;
            clMercadoria.Validade = Convert.ToInt32(TxtValidade.Text);
            clMercadoria.Marca = TxtMarca.Text;
            clMercadoria.Observacao = TxtObservacao.Text;

            if (CkbStatus.Checked == true) { clMercadoria.Status = 0; }
            if (CkbStatus.Checked == false) { clMercadoria.Status = 1; }


            if (TxtCodigo.Text == "")
            {
                try
                {
                    clMercadoria.Salvar();
                    Limpar();
                    MessageBox.Show("Dados gravados com sucesso!", "Confirmação.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não foi possível gravar os dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                try
                {
                    clMercadoria.Editar();
                    MessageBox.Show("Dados editados com sucesso!", "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não foi salvar as alterações.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Forms.GrdMercadoria grMercadoria = new Forms.GrdMercadoria();

            if (grMercadoria.ShowDialog() == DialogResult.OK)
            {
                clMercadoria.Retornar();
                TxtCodigo.Text = Classes.Mercadoria.idmercadoria.ToString();
                DtpDataCadastro.Text = clMercadoria.Datacadastro;
                TxtCodigoBarras.Text = clMercadoria.Codigodebarras.ToString();

                Grupo();

                TxtDescricao.Text = clMercadoria.Descricao;
                TxtPrecoCusto.Text = clMercadoria.Precocusto.ToString();
                TxtPrecoVenda.Text = clMercadoria.Precovenda.ToString();
                TxtEstoque.Text = clMercadoria.Estoque.ToString();
                CmbTipoItem.Text = clMercadoria.Tipoitem;
                TxtUnidade.Text = clMercadoria.Unidade;
                TxtValidade.Text = clMercadoria.Validade.ToString();
                TxtMarca.Text = clMercadoria.Marca;

                TxtObservacao.Text = clMercadoria.Observacao;

                if (clMercadoria.Status == 0) { CkbStatus.Checked = true; }
                if (clMercadoria.Status == 1) { CkbStatus.Checked = false; }
            }
        }

        private void CmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //id_grupo = Convert.ToInt32(CmbGrupo.SelectedValue);
            id_grupo = Convert.ToInt32(((DataRowView)CmbGrupo.SelectedValue)["id"]);
        }
    }
}
