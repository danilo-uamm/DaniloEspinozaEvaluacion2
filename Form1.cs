using DaniloEspinozaEvaluacion2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaniloEspinozaEvaluacion2
{
    public partial class Form1 : Form
    {

        private List<Model.Persona> lstPersonas = new List<Model.Persona>();
        int iEdad;
        private Persona PersonaNueva = new Persona();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrarPersona_Click(object sender, EventArgs e)
        {
            // casting de string a int, se debe validar campo edad
            if (!string.IsNullOrEmpty(txtEntryEdad.Text))
            {
                iEdad = int.Parse(txtEntryEdad.Text);
            }
            // Validar entradas con control de flujo

            if (string.IsNullOrEmpty(txtEntryPrimerNombre.Text))
            {
                MessageBox.Show("El primer nombre no debe ser vacio.");
                return;
            }

            if (string.IsNullOrEmpty(txtEntrySegundoNombre.Text))
            {
                MessageBox.Show("El segundo nombre no debe ser vacio.");
                return;
            }

            if (string.IsNullOrEmpty(txtEntryPrimerApellido.Text))
            {
                MessageBox.Show("El primer apellido no debe ser vacio.");
                return;
            }

            if (string.IsNullOrEmpty(txtEntrySegundoApellido.Text))
            {
                MessageBox.Show("El segundo apellido no debe ser vacio.");
                return;
            }
            if (string.IsNullOrEmpty(txtEntryEdad.Text))
            {
                MessageBox.Show("La edad no debe ser vacia.");
                return;
            }
            //validar campo edad, no debe ser 0 ni negativa
            if (iEdad <= 0)
            {
                MessageBox.Show("La edad no debe ser 0 ni negativa.");
                return;
            }



            // extrae los datos de la vista del usuario a nivel de memoria. posteriormente se agregan a la lista
            PersonaNueva = new Persona(txtEntryPrimerNombre.Text,
                txtEntrySegundoNombre.Text,
                txtEntryPrimerApellido.Text,
                txtEntrySegundoApellido.Text, iEdad);

            // primer caracter en mayuscula de cada campo
            PersonaNueva.sNombre1 = char.ToUpper(PersonaNueva.sNombre1[0]) + PersonaNueva.sNombre1.Substring(1);
            PersonaNueva.sNombre2 = char.ToUpper(PersonaNueva.sNombre2[0]) + PersonaNueva.sNombre2.Substring(1);
            PersonaNueva.sApellido1 = char.ToUpper(PersonaNueva.sApellido1[0]) + PersonaNueva.sApellido1.Substring(1);
            PersonaNueva.sApellido2 = char.ToUpper(PersonaNueva.sApellido2[0]) + PersonaNueva.sApellido2.Substring(1);

            lstPersonas.Add(PersonaNueva);

            // LIMPIAR LOS ENTRY FIELDS
            txtEntryPrimerNombre.Text = string.Empty;
            txtEntrySegundoNombre.Text = string.Empty;
            txtEntryPrimerApellido.Text = string.Empty;
            txtEntrySegundoApellido.Text = string.Empty;
            txtEntryEdad.Text = null;

            UpdateLst();

        }


        void UpdateLst()
        {
            lstBoxPersonas.Items.Clear();
            foreach (var persona in lstPersonas)
            {
                lstBoxPersonas.Items.Add(persona.ToString());
            }


        }
    }
}
