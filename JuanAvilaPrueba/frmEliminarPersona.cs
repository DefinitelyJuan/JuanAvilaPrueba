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
    public partial class frmEliminarPersona : Form
    {
        public frmEliminarPersona()
        {
            InitializeComponent();
        }

        private void frmEliminarPersona_Load(object sender, EventArgs e)
        {
            Helpers.WindowProperties(this);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PersonaTableAdapter persona = new PersonaTableAdapter();
            if (int.TryParse(txtID.Text, out int result))
            {
                string nombre = persona.getNameByID(result);
                if (nombre != null)
                {
                    System.Windows.MessageBoxResult confirmResult = System.Windows.MessageBox.Show($"Esta seguro que desea eliminar a {nombre} de la base de datos?", "Confirmar", System.Windows.MessageBoxButton.YesNo);
                    if (confirmResult == System.Windows.MessageBoxResult.Yes)
                    {
                        int response = persona.Delete(result);
                        if (response > 0)
                        {
                            MessageBox.Show("Persona Eliminada");
                            Helpers.ClearFormControls(this);
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar");
                        }
                    }
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
    }
}
