using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using MiLibreria;

namespace FactuXD
{
    public partial class VentanaUser : Form
    {
        public VentanaUser()
        {
            InitializeComponent();
        }

        private void VentanaUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaUser_Load(object sender, EventArgs e)
        {
            string cmd = string.Format("select * from Usuarios where id_usuario = '{0}'", VentanaLogin.codigo);
            DataSet ds = Utilidades.Ejecutar(cmd);

            LblNomUs.Text = ds.Tables[0].Rows[0]["Nom_usu"].ToString().Trim();
            LblUs.Text = ds.Tables[0].Rows[0]["account"].ToString().Trim();
            LblCodigo.Text = ds.Tables[0].Rows[0]["id_usuario"].ToString().Trim();

            string url = ds.Tables[0].Rows[0]["Foto"].ToString().Trim();

            pictureBox1.Image = Image.FromFile(url);
        }
    }
}
