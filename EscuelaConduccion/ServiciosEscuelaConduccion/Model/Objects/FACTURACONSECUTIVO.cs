using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosEscuelaConduccion.Model.Objects {

	[Serializable]

	public partial class FACTURACONSECUTIVO 
	{
		 public int ID { get; set; }
		 public float RANGO_INICIAL { get; set; }
		 public float RANGO_FINAL { get; set; }
		 public String SUFIJO { get; set; }
		 public String RESOLUCION { get; set; }
		 public DateTime FECHA_RESOLUCION { get; set; }
	}
}
