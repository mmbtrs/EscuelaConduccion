using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosEscuelaConduccion.Model.Objects {

	[Serializable]

	public partial class SALARIOMINIMO 
	{
		 public int ID { get; set; }
		 public int VIGENCIA { get; set; }
		 public float VALOR { get; set; }
	}
}
