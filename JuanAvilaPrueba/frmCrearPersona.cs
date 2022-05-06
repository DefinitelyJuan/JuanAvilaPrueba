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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonaTableAdapter persona = new PersonaTableAdapter();
            IFormatProvider format = System.Globalization.CultureInfo.GetCultureInfo("en-Us").DateTimeFormat;
            string dob = (selectFechaNacimiento.Value).ToString("yyyy-MM-dd", format);
            int response = persona.Insert(txtNombre.Text, DateTime.Parse(dob));
            if (response > 0)
            {
                MessageBox.Show("Persona Insertada");
                Helpers.ClearFormControls(this);
            }
            else
            {
                MessageBox.Show("Error en la inserción del cliente, verifique los datos ingresados");
            }
            
        }

        private void frmCrearPersona_Load(object sender, EventArgs e)
        {
            Helpers.WindowProperties(this);
        }
    }
}
