using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosEscuelaConduccion.Model.Objects {

	[Serializable]

	public partial class LIQUIDACION_DETALLE 
	{
		 public int ID { get; set; }
		 public int ID_LIQUIDACION { get; set; }
		 public int ID_TARIFA_DETALLE { get; set; }
		 public float VALOR_CONCEPTO { get; set; }
	}
}
