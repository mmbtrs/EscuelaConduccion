using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosEscuelaConduccion.objetos{

[Serializable]

public partial class Viewliquidacion {

	 public String NUMERO_RECIBO {get;set;}
	 public String NUMERO_FACTURA {get;set;}
	 public long ID_TIPO_DOCUMENTO {get;set;}
	 public String TIPO_DOCUMENTO {get;set;}
	 public String IDENTIFICACION {get;set;}
	 public long ID_ESTADO {get;set;}
	 public String ESTADO {get;set;}
	 public DateTime FECHA_LIQUIDACION {get;set;}
	 public DateTime FECHA_PAGO {get;set;}
	 public long ID_TIPO_LIQUIDACION {get;set;}
	 public String TIPO {get;set;}
	 public String TARIFA {get;set;}

	}

}
