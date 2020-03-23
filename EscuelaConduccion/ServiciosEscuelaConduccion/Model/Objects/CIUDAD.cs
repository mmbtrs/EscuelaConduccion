using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosEscuelaConduccion.Model.Objects {

	[Serializable]

	public partial class CIUDAD 
	{
		 public int ID { get; set; }
		 public int ID_DEPARTAMENTO { get; set; }
		 public String NOMBRE { get; set; }
	}
}
