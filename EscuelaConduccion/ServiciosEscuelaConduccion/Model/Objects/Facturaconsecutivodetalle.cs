using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosEscuelaConduccion.objetos{

[Serializable]

public partial class Facturaconsecutivodetalle {

	 public int ID {get;set;}
	 public int ID_FACTURACONSECUTIVO {get;set;}
	 public double CONSECUTIVO {get;set;}
	 public String DISPONIBLE {get;set;}

	}

}
