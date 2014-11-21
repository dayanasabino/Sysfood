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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        //Bloco de instâncias de classe.
        Classes.Banco clBanco = new Classes.Banco();

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Minimized;
            //this.WindowState = FormWindowState.Normal;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            CarregarLogin();
        }

        public void CarregarLogin()
        {
            clBanco.Login();
            CmbLogin.DisplayMember = "login";
            CmbLogin.DataSource = Classes.Banco.dt;
        }
    }
}
