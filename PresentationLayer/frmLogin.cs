using BusinessLogicalLayer;
using BusinessLogicalLayer.Helper;
using Common;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar a aplicação?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Administrator adm = new Administrator();
            adm.User = txtUser.Text;
            adm.Passcode = txtPasscode.Text.EncryptPassword();

            AdministratorBLL admBLL = new AdministratorBLL();
            SingleResponse<Administrator> response = admBLL.GetAdm(adm);
           
            if(response.Success)
            {
                frmHome f = new frmHome();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreta.");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }
    }
}
