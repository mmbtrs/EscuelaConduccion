using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosEscuelaConduccion.Model.Objects {

	[Serializable]

	public partial class TARIFA_DETALLE 
	{
		 public int ID { get; set; }
		 public int ID_TARIFA { get; set; }
		 public int ID_TARIFA_CONCEPTO { get; set; }
		 public String TERCERO { get; set; }
		 public String DESCONTABLE { get; set; }
		 public String FORMULA { get; set; }
	}
}
