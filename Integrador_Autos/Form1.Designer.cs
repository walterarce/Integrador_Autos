namespace Integrador_Autos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddPersona = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnEliminarPersona = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.btnAsignarAuto = new System.Windows.Forms.Button();
            this.grupoPersona = new System.Windows.Forms.GroupBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btnagregarPersona = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.grupoAuto = new System.Windows.Forms.GroupBox();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.btnagregarAuto = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.dtAnio = new System.Windows.Forms.DateTimePicker();
            this.cboModelo = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.dgPersona = new System.Windows.Forms.DataGridView();
            this.dgAutos = new System.Windows.Forms.DataGridView();
            this.dgAutosAsignados = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grupoPersona.SuspendLayout();
            this.grupoAuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAutosAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPersona
            // 
            this.btnAddPersona.BackColor = System.Drawing.Color.Green;
            this.btnAddPersona.ForeColor = System.Drawing.Color.White;
            this.btnAddPersona.Location = new System.Drawing.Point(38, 435);
            this.btnAddPersona.Name = "btnAddPersona";
            this.btnAddPersona.Size = new System.Drawing.Size(117, 23);
            this.btnAddPersona.TabIndex = 0;
            this.btnAddPersona.Text = "Agregar Persona";
            this.btnAddPersona.UseVisualStyleBackColor = false;
            this.btnAddPersona.Click += new System.EventHandler(this.btnAddPersona_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackColor = System.Drawing.Color.Green;
            this.btnAddCar.ForeColor = System.Drawing.Color.White;
            this.btnAddCar.Location = new System.Drawing.Point(377, 435);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(117, 23);
            this.btnAddCar.TabIndex = 1;
            this.btnAddCar.Text = "Agregar Auto";
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnEliminarPersona
            // 
            this.btnEliminarPersona.BackColor = System.Drawing.Color.Red;
            this.btnEliminarPersona.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPersona.Location = new System.Drawing.Point(161, 435);
            this.btnEliminarPersona.Name = "btnEliminarPersona";
            this.btnEliminarPersona.Size = new System.Drawing.Size(109, 23);
            this.btnEliminarPersona.TabIndex = 2;
            this.btnEliminarPersona.Text = "Eliminar Persona";
            this.btnEliminarPersona.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.BackColor = System.Drawing.Color.Red;
            this.btnDeleteCar.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCar.Location = new System.Drawing.Point(500, 435);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(109, 23);
            this.btnDeleteCar.TabIndex = 3;
            this.btnDeleteCar.Text = "Eliminar Auto";
            this.btnDeleteCar.UseVisualStyleBackColor = false;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // btnAsignarAuto
            // 
            this.btnAsignarAuto.BackColor = System.Drawing.Color.Blue;
            this.btnAsignarAuto.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarAuto.ForeColor = System.Drawing.Color.White;
            this.btnAsignarAuto.Location = new System.Drawing.Point(377, 373);
            this.btnAsignarAuto.Name = "btnAsignarAuto";
            this.btnAsignarAuto.Size = new System.Drawing.Size(127, 47);
            this.btnAsignarAuto.TabIndex = 4;
            this.btnAsignarAuto.Text = "Asignar Auto a Persona";
            this.btnAsignarAuto.UseVisualStyleBackColor = false;
            this.btnAsignarAuto.Click += new System.EventHandler(this.btnAsignarAuto_Click);
            // 
            // grupoPersona
            // 
            this.grupoPersona.Controls.Add(this.lblApellido);
            this.grupoPersona.Controls.Add(this.lblNombre);
            this.grupoPersona.Controls.Add(this.lblDNI);
            this.grupoPersona.Controls.Add(this.btnagregarPersona);
            this.grupoPersona.Controls.Add(this.txtApellido);
            this.grupoPersona.Controls.Add(this.txtNombre);
            this.grupoPersona.Controls.Add(this.txtDNI);
            this.grupoPersona.Location = new System.Drawing.Point(38, 464);
            this.grupoPersona.Name = "grupoPersona";
            this.grupoPersona.Size = new System.Drawing.Size(289, 133);
            this.grupoPersona.TabIndex = 5;
            this.grupoPersona.TabStop = false;
            this.grupoPersona.Text = "Persona";
            this.grupoPersona.Visible = false;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(19, 85);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(19, 25);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 4;
            this.lblDNI.Text = "DNI";
            // 
            // btnagregarPersona
            // 
            this.btnagregarPersona.BackColor = System.Drawing.Color.Green;
            this.btnagregarPersona.ForeColor = System.Drawing.Color.White;
            this.btnagregarPersona.Location = new System.Drawing.Point(197, 104);
            this.btnagregarPersona.Name = "btnagregarPersona";
            this.btnagregarPersona.Size = new System.Drawing.Size(75, 23);
            this.btnagregarPersona.TabIndex = 3;
            this.btnagregarPersona.Text = "Agregar";
            this.btnagregarPersona.UseVisualStyleBackColor = false;
            this.btnagregarPersona.Click += new System.EventHandler(this.btnagregarPersona_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(84, 78);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(188, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(188, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(84, 19);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 0;
            // 
            // grupoAuto
            // 
            this.grupoAuto.Controls.Add(this.lblprecio);
            this.grupoAuto.Controls.Add(this.lblAnio);
            this.grupoAuto.Controls.Add(this.lblModelo);
            this.grupoAuto.Controls.Add(this.lblMarca);
            this.grupoAuto.Controls.Add(this.lblPatente);
            this.grupoAuto.Controls.Add(this.btnagregarAuto);
            this.grupoAuto.Controls.Add(this.txtPrecio);
            this.grupoAuto.Controls.Add(this.dtAnio);
            this.grupoAuto.Controls.Add(this.cboModelo);
            this.grupoAuto.Controls.Add(this.cboMarca);
            this.grupoAuto.Controls.Add(this.txtPatente);
            this.grupoAuto.Location = new System.Drawing.Point(377, 464);
            this.grupoAuto.Name = "grupoAuto";
            this.grupoAuto.Size = new System.Drawing.Size(344, 165);
            this.grupoAuto.TabIndex = 6;
            this.grupoAuto.TabStop = false;
            this.grupoAuto.Text = "Auto";
            this.grupoAuto.Visible = false;
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(21, 135);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(37, 13);
            this.lblprecio.TabIndex = 11;
            this.lblprecio.Text = "Precio";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(20, 109);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(26, 13);
            this.lblAnio.TabIndex = 10;
            this.lblAnio.Text = "Año";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(20, 85);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 9;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(20, 52);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 8;
            this.lblMarca.Text = "Marca";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(20, 22);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(44, 13);
            this.lblPatente.TabIndex = 7;
            this.lblPatente.Text = "Patente";
            // 
            // btnagregarAuto
            // 
            this.btnagregarAuto.BackColor = System.Drawing.Color.Green;
            this.btnagregarAuto.ForeColor = System.Drawing.Color.White;
            this.btnagregarAuto.Location = new System.Drawing.Point(263, 132);
            this.btnagregarAuto.Name = "btnagregarAuto";
            this.btnagregarAuto.Size = new System.Drawing.Size(75, 23);
            this.btnagregarAuto.TabIndex = 4;
            this.btnagregarAuto.Text = "Agregar";
            this.btnagregarAuto.UseVisualStyleBackColor = false;
            this.btnagregarAuto.Click += new System.EventHandler(this.btnagregarAuto_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(138, 132);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // dtAnio
            // 
            this.dtAnio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAnio.Location = new System.Drawing.Point(138, 104);
            this.dtAnio.Name = "dtAnio";
            this.dtAnio.Size = new System.Drawing.Size(121, 20);
            this.dtAnio.TabIndex = 3;
            // 
            // cboModelo
            // 
            this.cboModelo.FormattingEnabled = true;
            this.cboModelo.Location = new System.Drawing.Point(138, 76);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(179, 21);
            this.cboModelo.TabIndex = 2;
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(138, 49);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(179, 21);
            this.cboMarca.TabIndex = 1;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(138, 25);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 20);
            this.txtPatente.TabIndex = 0;
            // 
            // dgPersona
            // 
            this.dgPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersona.Location = new System.Drawing.Point(25, 34);
            this.dgPersona.Name = "dgPersona";
            this.dgPersona.Size = new System.Drawing.Size(469, 150);
            this.dgPersona.TabIndex = 7;
            this.dgPersona.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPersona_RowEnter);
            // 
            // dgAutos
            // 
            this.dgAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAutos.Location = new System.Drawing.Point(500, 34);
            this.dgAutos.Name = "dgAutos";
            this.dgAutos.Size = new System.Drawing.Size(567, 150);
            this.dgAutos.TabIndex = 8;
            // 
            // dgAutosAsignados
            // 
            this.dgAutosAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAutosAsignados.Location = new System.Drawing.Point(25, 205);
            this.dgAutosAsignados.Name = "dgAutosAsignados";
            this.dgAutosAsignados.Size = new System.Drawing.Size(479, 150);
            this.dgAutosAsignados.TabIndex = 9;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(584, 205);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(367, 150);
            this.dataGridView3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Propietarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Autos para asignar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Autos Asignados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 665);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dgAutosAsignados);
            this.Controls.Add(this.dgAutos);
            this.Controls.Add(this.dgPersona);
            this.Controls.Add(this.grupoAuto);
            this.Controls.Add(this.grupoPersona);
            this.Controls.Add(this.btnAsignarAuto);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnEliminarPersona);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.btnAddPersona);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grupoPersona.ResumeLayout(false);
            this.grupoPersona.PerformLayout();
            this.grupoAuto.ResumeLayout(false);
            this.grupoAuto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAutosAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPersona;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnEliminarPersona;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Button btnAsignarAuto;
        private System.Windows.Forms.GroupBox grupoPersona;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Button btnagregarPersona;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.GroupBox grupoAuto;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Button btnagregarAuto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DateTimePicker dtAnio;
        private System.Windows.Forms.ComboBox cboModelo;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.DataGridView dgPersona;
        private System.Windows.Forms.DataGridView dgAutos;
        private System.Windows.Forms.DataGridView dgAutosAsignados;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

