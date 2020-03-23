using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosEscuelaConduccion.Model.Objects {

	[Serializable]

	public partial class VIEW_CIUDAD 
	{
		 public int ID { get; set; }
		 public String DEPARTAMENTO { get; set; }
		 public String CIUDAD { get; set; }
	}
}
