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

        private void BtnBuscar_Click(object sender, EventArgs e) //
        {
            Forms.GrdPerfilUsuario grdPerfil = new Forms.GrdPerfilUsuario();
            if (grdPerfil.ShowDialog() == DialogResult.OK)
            {
                clPerfil.Retornar();
                TxtCodigo.Text = Classes.PerfilUsuario.Idperfil.ToString();
                TxtDescricao.Text = clPerfil.Descricao;

                Definicaopermissao(); // Verificar

                if (clPerfil.Status == 0) { CkbStatus.Checked = true; }
                if (clPerfil.Status == 1) { CkbStatus.Checked = false; }
            }
        }

        private void FrmPerfilUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
