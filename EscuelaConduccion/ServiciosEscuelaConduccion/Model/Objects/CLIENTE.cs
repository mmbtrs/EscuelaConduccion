using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosEscuelaConduccion.Model.Objects {

	[Serializable]

	public partial class CLIENTE 
	{
		 public int ID { get; set; }
		 public int ID_GENERO { get; set; }
		 public int ID_CIUDAD { get; set; }
		 public int ID_TIPO_DOCUMENTO { get; set; }
		 public String IDENTIFICACION { get; set; }
		 public String NOMBRES { get; set; }
		 public String APELLIDOS { get; set; }
		 public String DIRECCION { get; set; }
		 public String TELEFONO { get; set; }
		 public String CELULAR { get; set; }
		 public String CORREO { get; set; }
		 public DateTime FECHA_NACIMIENTO { get; set; }
	}
}
