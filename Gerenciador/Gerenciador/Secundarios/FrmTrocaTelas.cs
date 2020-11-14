using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador.Secundarios
{
    public partial class FrmTrocaTelas : Form
    {
        public FrmTrocaTelas()
        {
            InitializeComponent();
        }

        private void BtnSim_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnNao_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal ObjMenu = new FrmMenuPrincipal();
            ObjMenu.txtUsuarioCookie.Text = txtUsuarioCookie.Text;
            ObjMenu.txtSenhaCookie.Text = txtSenhaCookie.Text;
            ObjMenu.Show();
            Close();
        }

        private void BtnDeslogar_Click(object sender, EventArgs e)
        {
            FrmLogin ObjLogin = new FrmLogin();
            ObjLogin.Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtSenhaCookie_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuarioCookie_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
