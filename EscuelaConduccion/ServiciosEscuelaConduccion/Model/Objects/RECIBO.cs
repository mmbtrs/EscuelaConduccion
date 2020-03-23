using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosEscuelaConduccion.Model.Objects {

	[Serializable]

	public partial class RECIBO 
	{
		 public int ID { get; set; }
		 public int ID_LIQUIDACION { get; set; }
		 public int ID_ESTADO { get; set; }
		 public String NUMERO_RECIBO { get; set; }
		 public DateTime FECHA_RECIBO { get; set; }
		 public DateTime FECHA_REGISTRO_PAGO { get; set; }
		 public DateTime FECHA_PAGO { get; set; }
		 public float VALOR { get; set; }
		 public DateTime FECHA_VENCIMIENTO { get; set; }
		 public DateTime FECHA_ENTRAMITE { get; set; }
		 public DateTime FECHA_ANULADO { get; set; }
		 public DateTime FECHA_PAGOANULADO { get; set; }
		 public DateTime FECHA_PROCESADO { get; set; }
		 public byte[] ARCHIVO_FISICO { get; set; }
	}
}
