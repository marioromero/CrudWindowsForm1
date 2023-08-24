using EjemploCrud.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCrud.Controladores
{
	public class UsuariosController : ControllerBase
	{
		public List<Usuario> ObtenerListaUsuarios()
		{

			return datos.Usuarios;
		}

		public void GuardarUsuario(Usuario usuario)
		{
			datos.Usuarios.Add(usuario);
		}

		public void EliminarUsuario(int index)
		{
			datos.Usuarios.RemoveAt(index);
		}

		public void ActualizarUsuario(int index, Usuario usuario)
		{
			datos.Usuarios.RemoveAt(index);
		}

	}
}
