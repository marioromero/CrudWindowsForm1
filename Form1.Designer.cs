namespace EjemploCrud
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.txtEdad = new System.Windows.Forms.TextBox();
			this.chbActivo = new System.Windows.Forms.CheckBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.txtRut = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dgUsuarios = new System.Windows.Forms.DataGridView();
			this.rbHombre = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.rbMujer = new System.Windows.Forms.RadioButton();
			this.cbCiudad = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(39, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Apellido";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(39, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Edad";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(89, 61);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(117, 20);
			this.txtNombre.TabIndex = 1;
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(89, 87);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(117, 20);
			this.txtApellido.TabIndex = 1;
			// 
			// txtEdad
			// 
			this.txtEdad.Location = new System.Drawing.Point(89, 113);
			this.txtEdad.Name = "txtEdad";
			this.txtEdad.Size = new System.Drawing.Size(38, 20);
			this.txtEdad.TabIndex = 1;
			// 
			// chbActivo
			// 
			this.chbActivo.AutoSize = true;
			this.chbActivo.Location = new System.Drawing.Point(150, 116);
			this.chbActivo.Name = "chbActivo";
			this.chbActivo.Size = new System.Drawing.Size(56, 17);
			this.chbActivo.TabIndex = 2;
			this.chbActivo.Text = "Activo";
			this.chbActivo.UseVisualStyleBackColor = true;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(236, 30);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 3;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(100, 219);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 23);
			this.btnGuardar.TabIndex = 3;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.Enabled = false;
			this.btnModificar.Location = new System.Drawing.Point(236, 75);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(75, 23);
			this.btnModificar.TabIndex = 3;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Enabled = false;
			this.btnEliminar.Location = new System.Drawing.Point(236, 120);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 3;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// txtRut
			// 
			this.txtRut.Location = new System.Drawing.Point(89, 35);
			this.txtRut.Name = "txtRut";
			this.txtRut.Size = new System.Drawing.Size(117, 20);
			this.txtRut.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(39, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(24, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Rut";
			// 
			// dgUsuarios
			// 
			this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgUsuarios.Location = new System.Drawing.Point(355, 29);
			this.dgUsuarios.Name = "dgUsuarios";
			this.dgUsuarios.Size = new System.Drawing.Size(508, 213);
			this.dgUsuarios.TabIndex = 4;
			this.dgUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsuarios_CellClick);
			// 
			// rbHombre
			// 
			this.rbHombre.AutoSize = true;
			this.rbHombre.Location = new System.Drawing.Point(87, 142);
			this.rbHombre.Name = "rbHombre";
			this.rbHombre.Size = new System.Drawing.Size(62, 17);
			this.rbHombre.TabIndex = 5;
			this.rbHombre.TabStop = true;
			this.rbHombre.Text = "Hombre";
			this.rbHombre.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(39, 144);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Genero";
			// 
			// rbMujer
			// 
			this.rbMujer.AutoSize = true;
			this.rbMujer.Location = new System.Drawing.Point(155, 142);
			this.rbMujer.Name = "rbMujer";
			this.rbMujer.Size = new System.Drawing.Size(51, 17);
			this.rbMujer.TabIndex = 5;
			this.rbMujer.TabStop = true;
			this.rbMujer.Text = "Mujer";
			this.rbMujer.UseVisualStyleBackColor = true;
			// 
			// cbCiudad
			// 
			this.cbCiudad.FormattingEnabled = true;
			this.cbCiudad.IntegralHeight = false;
			this.cbCiudad.Items.AddRange(new object[] {
            "Seleccione Una ciudad",
            "Talca",
            "Curicó",
            "Linares",
            "Cauquenes",
            "Dubai"});
			this.cbCiudad.Location = new System.Drawing.Point(85, 176);
			this.cbCiudad.Name = "cbCiudad";
			this.cbCiudad.Size = new System.Drawing.Size(153, 21);
			this.cbCiudad.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(875, 272);
			this.Controls.Add(this.cbCiudad);
			this.Controls.Add(this.rbMujer);
			this.Controls.Add(this.rbHombre);
			this.Controls.Add(this.dgUsuarios);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.chbActivo);
			this.Controls.Add(this.txtEdad);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.txtRut);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtEdad;
		private System.Windows.Forms.CheckBox chbActivo;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.TextBox txtRut;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dgUsuarios;
		private System.Windows.Forms.RadioButton rbHombre;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton rbMujer;
		private System.Windows.Forms.ComboBox cbCiudad;
	}
}

