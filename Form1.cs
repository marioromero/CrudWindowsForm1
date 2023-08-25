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
		UsuariosController UsuariosController = new UsuariosController(); //se instancia objeto para llamar a acciones crud del controller
		int filaSeleccionada;
		string accion = "guardar"; //la opción por defecto al pulsar el botón guardar, si se está editando, debe cambiar a editar

		//punto de partida de la app, mostramos lista usuarios (util si se tuviera datos por defecto, o desde una bd)
		public Form1()
		{
			InitializeComponent();
			try
			{
				MostrarListaUsuarios();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//asigna nombres de columna a cada row del datagrid y ubica dichos nombres como cabecera
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

			dgUsuarios.DataSource = tabla; //dgUsuarios = datagrid usuarios
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}
		//pobla el datagrid con los datos de la lista de usuarios
		private void MostrarListaUsuarios()
		{
			InicializarTablaUsuarios();

			List<Usuario> usuarios = UsuariosController.ObtenerListaUsuarios();

			if (usuarios != null)
			{
				foreach (var usuario in usuarios)
				{
					//si usuarios no es nulo, se le asigna a cada fila el valor de la propiedad que le corresponde.
					//el nombre del row debe coincidir con el de inicializarTablaUsuarios()
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

		//guarda/edita usuario
		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{

				//se define el género
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

				//la variable accion está por defecto en 'guardar' 
				if (accion == "guardar")
				{
					UsuariosController.GuardarUsuario(usuario);
				}
				else if (accion == "editar") //cuando se quiere editar, la acción debería estar en 'editar' ver función btnModificar_Click()
				{
					UsuariosController.ActualizarUsuario(filaSeleccionada, usuario);
					accion = "guardar";
				}

				MostrarListaUsuarios();
				LimpiarFormularioUsuarios();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//hace lo que su nombre dice
		private void LimpiarFormularioUsuarios()
		{
			txtNombre.Text = "";
			txtEdad.Text = "";
			txtRut.Text = "";
			txtApellido.Text = "";
			chbActivo.Checked = false;
		}

		//detecta cuando se le hace click a una celda el datagrid y guarda el indice correspondiente al registro seleccionado
		private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e) 
		{
			filaSeleccionada = e.RowIndex;
			btnEliminar.Enabled = true;
			btnModificar.Enabled = true;
		}

		//el boton eliminar llama a la funcion eliminar del controlador
		private void btnEliminar_Click(object sender, EventArgs e)
		{
			UsuariosController.EliminarUsuario(filaSeleccionada);
			btnEliminar.Enabled = false;
			btnModificar.Enabled = false;
			MostrarListaUsuarios();
		}


		//		Envía datos de la fila elegida al formulario para su edición

		private void btnModificar_Click(object sender, EventArgs e)
		{

			DataGridViewRow fila = dgUsuarios.Rows[filaSeleccionada];


			//definir género, se agrega check a opción que coincida con genero de fila elegida
			string genero = fila.Cells[5].Value.ToString();
			if (genero == "Hombre")
			{
				rbHombre.Checked = true;
			}
			else if (genero == "Mujer")
			{
				rbMujer.Checked = true;
			}

			txtRut.Text = fila.Cells[0].Value.ToString();
			txtNombre.Text = fila.Cells[1].Value.ToString();
			txtApellido.Text = fila.Cells[2].Value.ToString();
			txtEdad.Text = fila.Cells[3].Value.ToString();
			chbActivo.Checked = Convert.ToBoolean(fila.Cells[4].Value);
			cbCiudad.Text = fila.Cells[6].Value.ToString();

			accion = "editar";

			btnEliminar.Enabled = false;
			btnModificar.Enabled = false;
		}

		//limpia todos los campos y vuelve algunas cosas a su estado inicial
		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			LimpiarFormularioUsuarios();
			btnEliminar.Enabled = false;
			btnModificar.Enabled = false;
			accion = "guardar";
		}
	}
}
