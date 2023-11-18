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
    public partial class VentanaAdmin : Form
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        private void VentanaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaAdmin_Load(object sender, EventArgs e)
        {
            string cmd = string.Format("select * from Usuarios where id_usuario = '{0}'", VentanaLogin.codigo);
            DataSet ds = Utilidades.Ejecutar(cmd);

            LblNomAd.Text = ds.Tables[0].Rows[0]["Nom_usu"].ToString().Trim();
            LblUsadmin.Text = ds.Tables[0].Rows[0]["account"].ToString().Trim();
            LblCodigoAdmin.Text = ds.Tables[0].Rows[0]["id_usuario"].ToString().Trim();

            string url = ds.Tables[0].Rows[0]["Foto"].ToString().Trim();

            pictureBox1.Image = Image.FromFile(url);
        }
    }
}
