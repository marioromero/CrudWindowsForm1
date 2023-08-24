using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCrud.Controladores
{
	public class ControllerBase
	{
		public Datos datos { get; set; }

		public ControllerBase()
		{
			datos = new Datos();
		}
	}
}
