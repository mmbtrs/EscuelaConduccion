using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosEscuelaConduccion.Model.Objects
{

    [Serializable]

    public partial class TARIFA_CONCEPTO
    {
        public int ID { get; set; }
        public String CODIGO { get; set; }
        public String NOMBRE { get; set; }
        public String DESCRIPCION { get; set; }
        public String ESTADO { get; set; }
    }
}
