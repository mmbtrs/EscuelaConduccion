using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosEscuelaConduccion.Model.Objects {

	[Serializable]

	public partial class LIQUIDACION 
	{
		 public int ID { get; set; }
		 public int ID_CLIENTE { get; set; }
		 public int ID_TIPO_LIQUIDACION { get; set; }
		 public DateTime FECHA_LIQUIDACION { get; set; }
		 public float TOTAL { get; set; }
	}
}
