using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosEscuelaConduccion.Model.Objects {

	[Serializable]

	public partial class CONFIGURACIONINICIAL 
	{
		 public int ID { get; set; }
		 public String NOMBRE { get; set; }
		 public String DESCRIPCION { get; set; }
		 public String VALOR { get; set; }
		 public String ESTADO { get; set; }
	}
}
