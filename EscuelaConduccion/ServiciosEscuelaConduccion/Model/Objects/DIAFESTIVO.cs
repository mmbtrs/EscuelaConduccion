using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosEscuelaConduccion.Model.Objects {

	[Serializable]

	public partial class DIAFESTIVO 
	{
		 public int ID { get; set; }
		 public DateTime FECHA { get; set; }
		 public String DESCRIPCION { get; set; }
	}
}
