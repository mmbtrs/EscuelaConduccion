using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosEscuelaConduccion.Model.Objects {

	[Serializable]

	public partial class USUARIO 
	{
		 public int ID { get; set; }
		 public int ID_PERFIL { get; set; }
		 public int ID_TIPO_DOCUMENTO { get; set; }
		 public String LOGIN { get; set; }
		 public String PASSWORD { get; set; }
		 public DateTime FECHA_INGRESO { get; set; }
		 public DateTime FECHA_RETIRO { get; set; }
		 public String IDENTIFICACION { get; set; }
		 public String NOMBRES { get; set; }
		 public String APELLIDOS { get; set; }
		 public String ESTADO { get; set; }
		 public byte[] FOTO { get; set; }
	}
}
