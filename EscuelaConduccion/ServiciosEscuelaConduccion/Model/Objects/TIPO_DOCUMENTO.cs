using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosEscuelaConduccion.Model.Objects {

	[Serializable]

	public partial class TIPO_DOCUMENTO 
	{
		 public int ID { get; set; }
		 public String TIPO { get; set; }
		 public String ABREVIACION { get; set; }
	}
}
