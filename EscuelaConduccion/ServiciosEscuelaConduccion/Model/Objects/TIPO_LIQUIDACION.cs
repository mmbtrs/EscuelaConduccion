using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosEscuelaConduccion.Model.Objects {

	[Serializable]

	public partial class TIPO_LIQUIDACION 
	{
		 public int ID { get; set; }
		 public String TIPO { get; set; }
	}
}