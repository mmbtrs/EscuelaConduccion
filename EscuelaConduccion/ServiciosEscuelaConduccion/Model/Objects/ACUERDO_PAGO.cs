using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosEscuelaConduccion.Model.Objects {

	[Serializable]

	public partial class ACUERDO_PAGO 
	{
		 public int ID { get; set; }
		 public int ID_LIQUIDACION { get; set; }
		 public int ID_ACUERDO_ESTADO { get; set; }
		 public String NUMERO_ACUERDO { get; set; }
		 public DateTime FECHA_ACUERDO { get; set; }
	}
}
