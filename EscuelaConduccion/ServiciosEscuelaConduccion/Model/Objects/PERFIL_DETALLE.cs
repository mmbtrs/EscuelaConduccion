using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosEscuelaConduccion.Model.Objects {

	[Serializable]

	public partial class PERFIL_DETALLE 
	{
		 public int ID { get; set; }
		 public int ID_PERFIL { get; set; }
		 public String DESCRIPCION { get; set; }
		 public String MODULO { get; set; }
	}
}
