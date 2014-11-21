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
    }
}
