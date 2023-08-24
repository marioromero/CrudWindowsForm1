using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCrud.Modelos
{
	public class Usuario
	{
		public string Rut { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public int Edad { get; set; }
		public bool Activo { get; set; }
		public string Genero { get; set; }
		public string Ciudad { get; set; }

	}
}
