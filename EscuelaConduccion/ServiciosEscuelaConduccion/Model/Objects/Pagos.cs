using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosEscuelaConduccion.objetos{

[Serializable]

public partial class Pagos {

	 public int ID {get;set;}
	 public int ID_RECIBO {get;set;}
	 public int ID_FORMAPAGO {get;set;}
	 public double VALOR {get;set;}
	 public DateTime FECHA_PAGO {get;set;}

	}

}
