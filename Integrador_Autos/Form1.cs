using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador_Autos
{
    public partial class Form1 : Form
    {
        List<persona> ListaPersona = new List<persona>();
        List<auto> ListaAuto = new List<auto>();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboMarca.Items.Add("Ford");
            cboMarca.Items.Add("Chevrolet");
            cboMarca.Items.Add("Renault");
            cboMarca.Items.Add("Peugeot");
            cboMarca.Items.Add("Fiat");

            cboModelo.Items.Add("Ka");
            cboModelo.Items.Add("Blazer");
            cboModelo.Items.Add("Kangoo");
            cboModelo.Items.Add("208");
            cboModelo.Items.Add("Cronos");

        }

        //dataGridView1.CurrentRow.Index;
        private void btnagregarPersona_Click(object sender, EventArgs e)
        {
            persona Persona = new persona(txtDNI.Text, txtNombre.Text, txtApellido.Text);
            ListaPersona.Add(Persona);
            
            dgPersona.DataSource = ListaPersona.ToList();
            
            txtDNI.Text = null;
            txtNombre.Text = null;
            txtApellido.Text = null;
            grupoPersona.Visible = false;
        }

        private void btnAddPersona_Click(object sender, EventArgs e)
        {
            grupoPersona.Visible = true;
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
         

            grupoAuto.Visible = true;
        }

        private void btnagregarAuto_Click(object sender, EventArgs e)
        {
            auto Auto = new auto(txtPatente.Text, cboMarca.Text, cboModelo.Text, dtAnio.Text, Convert.ToDecimal(txtPrecio.Text));
            ListaAuto.Add(Auto);

            dgAutos.DataSource = ListaAuto.ToList();

            txtPatente.Text = null;
            txtPrecio.Text = null;
            grupoAuto.Visible = false;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

    

        private void dgPersona_Click(object sender, EventArgs e)
        {

        }

        private void dgPersona_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgPersona.CurrentCell.Selected)
            {
              
                foreach (var personas in ListaPersona)
                {
                    if (personas.DNI == dgPersona.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        MessageBox.Show(personas.ToString());
                    }
                }
            }
        }

        private void btnAsignarAuto_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dgAutos.Text);

        }

        private void dgAutos_Click(object sender, EventArgs e)
        {

        }

        private void dgAutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgAutos.CurrentCell.Selected)
            {
                
                foreach (var autos in ListaAuto)
                {
                    if(autos.Patente== dgAutos.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        MessageBox.Show(autos.ToString());
                    }
                }
          
            }
        }
    }
}
