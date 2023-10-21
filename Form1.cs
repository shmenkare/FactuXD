using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MiLibreria;
using System.Data;

namespace FactuXD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("select * from usuarios where account = '{0}' and password = '{1}'", txtNomAcc.Text.Trim(), txtPass.Text.Trim());

                DataSet ds = Utilidades.Ejecutar(sql);

                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();

                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();

                if (cuenta == txtNomAcc.Text.Trim() && contra == txtPass.Text.Trim())
                {
                    MessageBox.Show("Se ha iniciado sesion");
                }

            }
            catch
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }
    }
}