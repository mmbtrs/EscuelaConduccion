using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosEscuelaConduccion.Model.Objects {

	[Serializable]

	public partial class VIEW_CLIENTE 
	{
		 public int ID { get; set; }
		 public String TIPO_DOCUMENTO { get; set; }
		 public String IDENTIFICACION { get; set; }
		 public String NOMBRES { get; set; }
		 public String APELLIDOS { get; set; }
		 public String DIRECCION { get; set; }
		 public String CIUDAD { get; set; }
		 public String DEPARTAMENTO { get; set; }
		 public String GENERO { get; set; }
		 public String TELEFONO { get; set; }
		 public String CELULAR { get; set; }
		 public String CORREO { get; set; }
		 public String FECHA_NACIMIENTO { get; set; }
	}
}
