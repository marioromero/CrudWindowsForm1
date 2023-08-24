using EjemploCrud.Controladores;
using EjemploCrud.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploCrud
{
	public partial class Form1 : Form
	{
		private DataTable tabla;
		UsuariosController UsuariosController = new UsuariosController();
		int filaSeleccionada;

		public Form1()
		{
			InitializeComponent();
			try
			{
				InicializarTablaUsuarios();
				MostrarListaUsuarios();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void InicializarTablaUsuarios()
		{
			tabla = new DataTable();
			tabla.Columns.Add("Rut");
			tabla.Columns.Add("Nombre");
			tabla.Columns.Add("Apellido");
			tabla.Columns.Add("Edad");
			tabla.Columns.Add("Activo");
			tabla.Columns.Add("Genero");
			tabla.Columns.Add("Ciudad");

			dgUsuarios.DataSource = tabla;
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void MostrarListaUsuarios()
		{
			InicializarTablaUsuarios();

			List<Usuario> usuarios = UsuariosController.ObtenerListaUsuarios();

			if (usuarios != null)
			{
				foreach (var usuario in usuarios)
				{
					DataRow row = tabla.NewRow();
					row["Rut"] = usuario.Rut;
					row["Nombre"] = usuario.Nombre;
					row["Apellido"] = usuario.Apellido;
					row["Edad"] = usuario.Edad;
					row["Activo"] = usuario.Activo;
					row["Genero"] = usuario.Genero;
					row["Ciudad"] = usuario.Ciudad;

					tabla.Rows.Add(row);
				}
			}
		}


		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				string genero = "";

				if (rbHombre.Checked)
				{
					genero = "Hombre";
				}
				else if (rbMujer.Checked)
				{
					genero = "Mujer";
				}

				if (cbCiudad.SelectedIndex == 0)
					throw new Exception("Elige una ciudad válida");

				Usuario usuario = new Usuario()
				{
					Rut = txtNombre.Text,
					Edad = int.Parse(txtEdad.Text),
					Nombre = txtNombre.Text,
					Apellido = txtApellido.Text,
					Activo = chbActivo.Checked,
					Genero = genero,
					Ciudad = cbCiudad.Text
					
				};

				UsuariosController.GuardarUsuario(usuario);
				MostrarListaUsuarios();
				LimpiarFormularioUsuarios();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LimpiarFormularioUsuarios()
		{
			txtNombre.Text = "";
			txtEdad.Text = "";
			txtRut.Text = "";
			txtApellido.Text = "";
			chbActivo.Checked = false;
		}

		private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e) //
		{
			filaSeleccionada = e.RowIndex;
			btnEliminar.Enabled = true;
			btnModificar.Enabled = true;
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			UsuariosController.EliminarUsuario(filaSeleccionada);
			btnEliminar.Enabled = false;
			btnModificar.Enabled = false;
			MostrarListaUsuarios();
		}

		private void btnModificar_Click(object sender, EventArgs e)
		{

		}
	}
}
