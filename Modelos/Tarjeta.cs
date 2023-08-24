using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCrud.Modelos
{
	public class Tarjeta
	{
		public string Numero { get; set; }
		public int Cvc { get; set; }
		public DateTime Vencimiento { get; set; }
	}
}
