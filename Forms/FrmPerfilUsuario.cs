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
    public partial class FrmPerfilUsuario : Form
    {
        Classes.PerfilUsuario clPerfil = new Classes.PerfilUsuario();
        
        public FrmPerfilUsuario()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();

            if (MessageBox.Show("Deseja fechar a janela?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Definicaopermissao();
            clPerfil.Descricao = TxtDescricao.Text;
            clPerfil.Gravar();
            MessageBox.Show("Dados gravados com sucesso!", "Sucesso.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
        }

        public void LimparCampos()
        {
            TxtDescricao.Clear();
            TxtCodigo.Clear();

            foreach (Control ctrl in groupBox2.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox ckb = (CheckBox)ctrl;

                    if (ckb.Checked)
                    {
                        ckb.Checked = false;
                    }
                }
            }
        }

        public int Definicaopermissao()
        {
            clPerfil.Permissoes = new int[11];

            if (CkbCliente.Checked == true) { clPerfil.Permissoes[0] = 1; } else { clPerfil.Permissoes[0] = 0; }
            if (CkbEmpresa.Checked == true) { clPerfil.Permissoes[1] = 1; } else { clPerfil.Permissoes[1] = 0; }
            if (CkbFormadePagamento.Checked == true) { clPerfil.Permissoes[2] = 1; } else { clPerfil.Permissoes[2] = 0; }
            if (CkbGrupo.Checked == true) { clPerfil.Permissoes[3] = 1; } else { clPerfil.Permissoes[3] = 0; }
            if (CkbPerfildeUsuario.Checked == true) { clPerfil.Permissoes[4] = 1; } else { clPerfil.Permissoes[4] = 0; }
            if (CkbMercadoria.Checked == true) { clPerfil.Permissoes[5] = 1; } else { clPerfil.Permissoes[5] = 0; }
            if (CkbUsuario.Checked == true) { clPerfil.Permissoes[6] = 1; } else { clPerfil.Permissoes[6] = 0; }
            if (CkbComanda.Checked == true) { clPerfil.Permissoes[7] = 1; } else { clPerfil.Permissoes[7] = 0; }
            if (CkbTelefone.Checked == true) { clPerfil.Permissoes[8] = 1; } else { clPerfil.Permissoes[8] = 0; }
            if (CkbContasaReceber.Checked == true) { clPerfil.Permissoes[9] = 1; } else { clPerfil.Permissoes[9] = 0; }
            if (CkbRelatorios.Checked == true) { clPerfil.Permissoes[10] = 1; } else { clPerfil.Permissoes[10] = 0; }

            return clPerfil.Permissoes[5];
        }

        public void DefineCheckbox()
        {
            string permissao = clPerfil.auxpermissao;

            int acessCliente, acessEmpresa, acessFrmPagmento, acessGrupo, acessPerfil, acessMercadoria, acessUsuario, acessComanda, acessTelefone, acessRecebimento, acessRelatorio;

            //1|1|1|1|1|1|1|1|1|1|0
            acessCliente = Convert.ToInt32(permissao.Substring(0, 1));
            acessEmpresa = Convert.ToInt32(permissao.Substring(2, 1));
            acessFrmPagmento = Convert.ToInt32(permissao.Substring(4, 1));
            acessGrupo = Convert.ToInt32(permissao.Substring(6, 1));
            acessPerfil = Convert.ToInt32(permissao.Substring(8, 1));
            acessMercadoria = Convert.ToInt32(permissao.Substring(10, 1));
            acessUsuario = Convert.ToInt32(permissao.Substring(12, 1));
            acessComanda = Convert.ToInt32(permissao.Substring(14, 1));
            acessTelefone = Convert.ToInt32(permissao.Substring(16, 1));
            acessRecebimento = Convert.ToInt32(permissao.Substring(18, 1));
            acessRelatorio = Convert.ToInt32(permissao.Substring(20, 1));


            if (acessCliente == 1 ? CkbCliente.Checked = true : CkbCliente.Checked = false); 
            if (acessEmpresa == 1 ? CkbEmpresa.Checked = true : CkbEmpresa.Checked = false); 
            if (acessFrmPagmento == 1 ? CkbFormadePagamento.Checked = true : CkbFormadePagamento.Checked = false); 
            if (acessGrupo == 1 ? CkbGrupo.Checked = true : CkbGrupo.Checked = false); 
            if (acessPerfil == 1 ? CkbPerfildeUsuario.Checked = true : CkbPerfildeUsuario.Checked = false); 
            if (acessMercadoria == 1 ? CkbMercadoria.Checked = true : CkbMercadoria.Checked = false); 
            if (acessUsuario == 1 ? CkbUsuario.Checked = true : CkbUsuario.Checked = false); 
            if (acessComanda == 1 ? CkbComanda.Checked = true : CkbComanda.Checked = false); 
            if (acessTelefone == 1 ? CkbTelefone.Checked = true : CkbTelefone.Checked = false); 
            if (acessRecebimento == 1 ? CkbContasaReceber.Checked = true : CkbContasaReceber.Checked = false); 
            if (acessRelatorio == 1 ? CkbRelatorios.Checked = true : CkbRelatorios.Checked = false);
 
            //Porque você não olha pra mim, oooo, me diz oque que eu tenho e mal ooo By Jude

        }

        private void BtnBuscar_Click(object sender, EventArgs e) //
        {
            Forms.GrdPerfilUsuario grdPerfil = new Forms.GrdPerfilUsuario();
            if (grdPerfil.ShowDialog() == DialogResult.OK)
            {
                clPerfil.Retornar();
                TxtCodigo.Text = Classes.PerfilUsuario.Idperfil.ToString();
                TxtDescricao.Text = clPerfil.Descricao;

                DefineCheckbox(); // oi

                if (clPerfil.Status == 0) { CkbStatus.Checked = true; }
                if (clPerfil.Status == 1) { CkbStatus.Checked = false; }
            }
        }

        private void FrmPerfilUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
