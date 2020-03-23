using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiciosEscuelaConduccion.Model.Objects
{

    [Serializable]

    public partial class TARIFA
    {
        public int ID { get; set; }
        public int ID_VIGENCIA { get; set; }
        public int ID_TARIFA_CATEGORIA { get; set; }
        public String NOMBRE { get; set; }
        public String ESTADO { get; set; }
    }
}
