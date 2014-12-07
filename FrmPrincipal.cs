using SysFood.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysFood
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CorFundo();
            verificaPermissao();
        }

        private void perfilDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FrmPerfilUsuario perfil = new Forms.FrmPerfilUsuario();
            perfil.MdiParent = this;
            perfil.Show();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FrmUsuario usuario = new Forms.FrmUsuario();
            usuario.MdiParent = this;
            usuario.Show();
        }

        public void verificaPermissao()
        {
            Banco bg = new Banco();
            string permissao = Banco.permissaoUsuario;

            int acessCliente, acessEmpresa, acessFrmPagmento, acessGrupo, acessPerfil, acessMercadoria, acessUsuario, acessComanda, acessTelefone, acessRecebimento, acessRelatorio;

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

            if (acessCliente == 1 ? clienteToolStripMenuItem.Enabled = true : clienteToolStripMenuItem.Enabled = false) ;
            if (acessEmpresa == 1 ? empresaToolStripMenuItem.Enabled = true : empresaToolStripMenuItem.Enabled = false) ;
            if (acessFrmPagmento == 1 ? formaDePagamentoToolStripMenuItem.Enabled = true : formaDePagamentoToolStripMenuItem.Enabled = false) ;
            if (acessGrupo == 1 ? grupoToolStripMenuItem.Enabled = true : grupoToolStripMenuItem.Enabled = false) ;
            if (acessPerfil == 1 ? perfilDeUsuárioToolStripMenuItem.Enabled = true : perfilDeUsuárioToolStripMenuItem.Enabled = false) ;
            if (acessMercadoria == 1 ? produtoToolStripMenuItem.Enabled = true : produtoToolStripMenuItem.Enabled = false) ;
            if (acessUsuario == 1 ? usuárioToolStripMenuItem.Enabled = true : usuárioToolStripMenuItem.Enabled = false) ;
            if (acessComanda == 1 ? comandaToolStripMenuItem.Enabled = true : comandaToolStripMenuItem.Enabled = false) ;
            if (acessTelefone == 1 ? cardápioToolStripMenuItem.Enabled = true : cardápioToolStripMenuItem.Enabled = false) ;
            if (acessRecebimento == 1 ? contasAReceberToolStripMenuItem.Enabled = true : contasAReceberToolStripMenuItem.Enabled = false) ;
            if (acessRelatorio == 1 ? relatóriosToolStripMenuItem.Enabled = true : relatóriosToolStripMenuItem.Enabled = false) ;
 

        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Encerrar a Aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        public void CorFundo()
        {
            // Defina a propriedade BackColor como a cor que você deseja
            MdiClient ctlMDI;

            // Loop through all of the form's controls looking
            // for the control of type MdiClient.

            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FrmEmpresa empresa = new Forms.FrmEmpresa();
            empresa.MdiParent = this;
            empresa.Show();
        }

        private void grupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FrmGrupo grupo = new Forms.FrmGrupo();
            grupo.MdiParent = this;
            grupo.Show();
        }

        private void formaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FrmFormaPagamento pagamento = new Forms.FrmFormaPagamento();
            pagamento.MdiParent = this;
            pagamento.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FrmCliente cliente = new Forms.FrmCliente();
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FrmMercadoria mercadoria = new Forms.FrmMercadoria();
            mercadoria.MdiParent = this;
            mercadoria.Show();
        }

        private void cardápioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FrmAtendimentoTelefonico attel = new Forms.FrmAtendimentoTelefonico();
            attel.MdiParent = this;
            attel.Show();
        }

        private void comandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FrmMesaComanda mc = new Forms.FrmMesaComanda();
            mc.MdiParent = this;
            mc.Show();
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.FrmRecebimentos recebimentos = new Forms.FrmRecebimentos();
            recebimentos.MdiParent = this;
            recebimentos.Show();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
