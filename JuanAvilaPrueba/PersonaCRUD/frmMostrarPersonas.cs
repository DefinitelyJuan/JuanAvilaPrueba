using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuanAvilaPrueba
{
    public partial class frmMostrarPersonas : Form
    {
        public frmMostrarPersonas()
        {
            InitializeComponent();
            this.Text = "Mostrar Personas";
        }

        private void frmMostrarPersonas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsJAPrueba.Persona' Puede moverla o quitarla según sea necesario.
            try
            {
                this.personaTableAdapter.Fill(this.dsJAPrueba.Persona);

            }
            catch (Exception err)
            {
                MessageBox.Show($"Ocurrio un error: {err.Message}");
            }

            Helpers.WindowProperties(this);
        }
    }
}
