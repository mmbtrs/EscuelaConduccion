using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosEscuelaConduccion.Model.Objects {

	[Serializable]

	public partial class FACTURA 
	{
		 public int ID { get; set; }
		 public int ID_FACTURA_ESTADO { get; set; }
		 public int ID_LIQUIDACION { get; set; }
		 public String NUMERO_FACTURA { get; set; }
		 public String DISPONIBLE { get; set; }
		 public byte[] ARCHIVO_FISICO { get; set; }
	}
}
