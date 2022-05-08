using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JuanAvilaPrueba.dsJAPruebaTableAdapters;
namespace JuanAvilaPrueba
{
    public partial class frmCrearPersona : Form
    {
        public frmCrearPersona()
        {
            InitializeComponent();
            this.Text = "Crear Persona";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonaTableAdapter persona = new PersonaTableAdapter();
            IFormatProvider format = System.Globalization.CultureInfo.GetCultureInfo("en-Us").DateTimeFormat;
            string dob = (selectFechaNacimiento.Value).ToString("yyyy-MM-dd", format);
            try
            {
                int response = persona.Insert(txtNombre.Text, DateTime.Parse(dob));
                if (response > 0)
                {
                    MessageBox.Show("Persona insertada correctamente");
                    Helpers.ClearFormControls(this);
                }
                else
                {
                    MessageBox.Show("Error en la inserción del registro, verifique los datos ingresados");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ocurrio un error: {err.Message}");
            }                        
        }

        private void frmCrearPersona_Load(object sender, EventArgs e)
        {
            Helpers.WindowProperties(this);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void selectFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
