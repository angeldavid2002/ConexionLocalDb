using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidades;

namespace Presentacion
{
    public partial class FrmInicio : Form
    {
        PersonaService personaService;

        public FrmInicio()
        {
            InitializeComponent();
            personaService = new PersonaService(ConfigConnection.connectionString);
            EstablecerComponentes();
        }
        public void EstablecerComponentes()
        {
            LblVersion.Visible = false;
            LbelRespuesta1.Visible = false;
            LbelRespuesta2.Visible = false;
            LblResultadoEjecucion.Visible = false;
        }
        private void MostrarLabels()
        {
            LblVersion.Visible = true;
            LbelRespuesta1.Visible = true;
            LbelRespuesta2.Visible = true;
            LblResultadoEjecucion.Visible = true;
        }

        private void BtnMostrarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarLabels();
                LbelRespuesta1.Text = personaService.probarConexion().conOpen;
                LbelRespuesta2.Text = personaService.probarConexion().conClose;
                LblVersion.Text = personaService.probarConexion().versionServer;
                LblResultadoEjecucion.Text = personaService.probarConexion().error;
            }
            catch (Exception ex)
            {
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show("Error en la aplicacion!!!",ex.Message,botones);
            }
        }
    }
}
