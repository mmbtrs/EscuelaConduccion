using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosEscuelaConduccion.Model.Objects {

	[Serializable]

	public partial class ACUERDO_PAGO_DETALLE 
	{
		 public int ID { get; set; }
		 public int ID_ACUERDO_PAGO { get; set; }
		 public int ID_RECIBO { get; set; }
		 public int NUMERO_CUOTA { get; set; }
		 public float VALOR { get; set; }
		 public DateTime FECHA_LIMITE_PAGO { get; set; }
		 public float PORCENTAJE { get; set; }
	}
}
