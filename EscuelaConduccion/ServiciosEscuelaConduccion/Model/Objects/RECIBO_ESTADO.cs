using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosEscuelaConduccion.Model.Objects {

	[Serializable]

	public partial class RECIBO_ESTADO 
	{
		 public int ID { get; set; }
		 public String ESTADO { get; set; }
		 public String DESCRIPCION_ESTADO { get; set; }
	}
}
