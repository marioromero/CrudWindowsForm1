using EjemploCrud.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCrud
{
	public class Datos
	{
		public List<Usuario> Usuarios { get; set; }
		public List<Tarjeta> Tarjetas { get; set; }

		public Datos()
		{
			Usuarios = new List<Usuario>();
			Tarjetas = new List<Tarjeta>();
		}


	}
}
