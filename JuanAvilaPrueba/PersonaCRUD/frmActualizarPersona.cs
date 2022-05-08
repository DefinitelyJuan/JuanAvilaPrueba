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
    public partial class frmActualizarPersona : Form
    {
        public frmActualizarPersona()
        {
            InitializeComponent();
            this.Text = "Actualizar Persona";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            PersonaTableAdapter persona = new PersonaTableAdapter();
            IFormatProvider format = System.Globalization.CultureInfo.GetCultureInfo("en-Us").DateTimeFormat;
            string dob = (selectFechaNacimiento.Value).ToString("yyyy-MM-dd", format);
            try
            {
                int response = persona.Update(txtNombre.Text, dob, int.Parse(txtID.Text));
                if(response > 0)
                {
                    MessageBox.Show("El registro ha sido actualizado");
                }
                else
                {
                    MessageBox.Show("Error en la actualización del registro, verifique los datos ingresados");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ocurrio un error: {err.Message}");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PersonaTableAdapter persona = new PersonaTableAdapter();
            if (int.TryParse(txtID.Text, out int result))
            {
                DataTable query = persona.GetPersonaByID(result);
                if(query.Rows.Count > 0)
                {
                    btnActualizar.Enabled = true;
                    btnActualizar.BackColor = Color.SpringGreen;
                    txtNombre.Text = query.Rows[0][1].ToString();
                    txtNombre.Enabled = true;
                    selectFechaNacimiento.Text = query.Rows[0][2].ToString();
                    selectFechaNacimiento.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No existen registros en la base de datos para el ID ingresado");
                }
                
            }
            else
            {
                MessageBox.Show("Debe ingresar un número entero");
            }            
        }

        private void frmActualizarPersona_Load(object sender, EventArgs e)
        {
            Helpers.WindowProperties(this);
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Clear();
            selectFechaNacimiento.Text = DateTime.Now.ToString();
            btnActualizar.Enabled = false;
            txtNombre.Enabled = false;
            selectFechaNacimiento.Enabled = false;
        }
    }
}
