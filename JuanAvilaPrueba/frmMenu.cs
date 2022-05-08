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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.favicon;
            this.Text = "Menu Principal";
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helpers.CloseMdiChild(this,label1,label2);
            frmCrearPersona crearPersona = new frmCrearPersona();
            crearPersona.MdiParent = this;
            crearPersona.Show();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helpers.CloseMdiChild(this, label1, label2);
            frmMostrarPersonas mostrarPersonas = new frmMostrarPersonas();
            mostrarPersonas.MdiParent = this;
            mostrarPersonas.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helpers.CloseMdiChild(this, label1, label2);
            frmEliminarPersona eliminarPersona = new frmEliminarPersona();
            eliminarPersona.MdiParent = this;
            eliminarPersona.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helpers.CloseMdiChild(this, label1, label2);
            frmActualizarPersona actualizarPersona = new frmActualizarPersona();
            actualizarPersona.MdiParent = this;
            actualizarPersona.Show();
        }
    }
}
