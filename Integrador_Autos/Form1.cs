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
        List<Persona> ListaPersona = new List<Persona>();
        List<Auto> ListaAuto = new List<Auto>();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dgPersona.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPersona.MultiSelect = false;
            dgAutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgAutos.MultiSelect = false;
            dgAutosAsignados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgAutosAsignados.MultiSelect = false;
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

            ListaPersona.AddRange(new Persona[] { new Persona("232323", "Ana", "Garcia"), new Persona("232323", "Juan", "Perez"), new Persona("44", "Sol", "Martinez") });
            ListaAuto.AddRange(new Auto[] { new Auto("AB146ZX", "Audi","ss","2323",2323), new Auto("BC154ZX", "BMW","wewe","1999", 2323) });

            dgPersona.DataSource = null;
            dgPersona.DataSource = ListaPersona;
            dgAutos.DataSource = null;
            dgAutos.DataSource = ListaAuto;
        }

        //dataGridView1.CurrentRow.Index;
        private void btnagregarPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(txtDNI.Text, txtNombre.Text, txtApellido.Text);
            ListaPersona.Add(persona);
            
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
            Auto auto = new Auto(txtPatente.Text, cboMarca.Text, cboModelo.Text, dtAnio.Text, Convert.ToDecimal(txtPrecio.Text));
            ListaAuto.Add(auto);

            dgAutos.DataSource = ListaAuto.ToList();

            txtPatente.Text = null;
            txtPrecio.Text = null;
            grupoAuto.Visible = false;
        }
  
        


        private void btnAsignarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                Persona p = (Persona)(dgPersona.SelectedRows[0].DataBoundItem);
                Auto a = (Auto)(dgAutos.SelectedRows[0].DataBoundItem);
                p.Agregar_Auto(a);

                dgAutosAsignados.DataSource = null;
                dgAutosAsignados.DataSource = p.RetornarAutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgPersona_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgAutosAsignados.DataSource = null;
                dgAutosAsignados.DataSource = ((Persona)dgPersona.SelectedRows[0].DataBoundItem).RetornarAutos();
            }
            catch (Exception )
            {
            }
            
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            var personagrilla1 = ((Persona)dgPersona.SelectedRows[0].DataBoundItem);
            var autogrillaauto = ((Auto) (dgAutos.SelectedRows[0].DataBoundItem));
            var autogrillaasignado = ((Auto)(dgAutosAsignados.SelectedRows[0].DataBoundItem));

            if (autogrillaasignado.Patente == autogrillaauto.Patente)
            {
                autogrillaauto.propietario = null;
                personagrilla1.Eliminar_auto(autogrillaauto);
            }
            else
            {
                MessageBox.Show("Seleccione por favor el auto a desasignar");
                
            }
           

            try
            {
                dgAutosAsignados.DataSource = null;
                dgAutosAsignados.DataSource = ((Persona)dgPersona.SelectedRows[0].DataBoundItem).RetornarAutos();
            }
            catch (Exception)
            {
            }
        }

       
    }
}
