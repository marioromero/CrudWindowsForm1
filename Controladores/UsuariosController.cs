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
			Usuario usuarioExistente = datos.Usuarios[index];

			usuarioExistente.Rut = usuario.Rut;
			usuarioExistente.Edad = usuario.Edad;
			usuarioExistente.Nombre = usuario.Nombre;
			usuarioExistente.Apellido = usuario.Apellido;
			usuarioExistente.Activo = usuario.Activo;
			usuarioExistente.Genero = usuario.Genero;
			usuarioExistente.Ciudad = usuario.Ciudad;
		}

	}
}
