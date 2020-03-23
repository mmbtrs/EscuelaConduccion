using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosEscuelaConduccion.objetos{

[Serializable]

public partial class Viewrecibo {

	 public int ID {get;set;}
	 public String NUMERO_RECIBO {get;set;}
	 public double VALOR {get;set;}
	 public int ID_CLIENTE {get;set;}
	 public String NOMBRES {get;set;}
	 public String APELLIDOS {get;set;}
	 public int ID_ESTADO {get;set;}
	 public String ESTADO {get;set;}
	 public int ID_TIPO_LIQUIDACION {get;set;}
	 public String TIPO_PAGO {get;set;}

	}

}
