using ServiciosEscuelaConduccion.Model.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosEscuelaConduccion.Model.Managements
{
    public class GESTIONVariables
    {
        CLIENTE cliente;
        TARIFA tarifa;

        public GESTIONVariables(int id_cliente, TARIFA myTarifa)
        {
            cliente = new CLIENTE();
            cliente.ID = id_cliente;
            obtenerCliente();
            tarifa = myTarifa;
        }

        private void obtenerCliente()
        {
            try
            {
                CLIENTEManagement cLIENTEManagement = new CLIENTEManagement();
                cliente = cLIENTEManagement.buscarPrimeroCLIENTE(cliente);
            }
            catch (Exception exp)
            {
                cliente = null;
            }
        }

        public string reemplazarVariables(string texto)
        {
            if (!String.IsNullOrEmpty(texto))
            {
                foreach (String textovariable in Enum.GetNames(typeof(VARIABLES)))
                {
                    VARIABLES va = (VARIABLES)Enum.Parse(typeof(VARIABLES), textovariable);
                    texto = texto.Replace(textovariable, obtenerValorVariable(va));
                }
                return texto;
            }

            return null;
        }

        private string obtenerValorVariable(VARIABLES variable)
        {

            string result = "0";
            if (variable == VARIABLES.SEXO)
                result = obtenerSEXO();
            else if (variable == VARIABLES.EDAD)
                result = obtenerEDAD();
            else if (variable == VARIABLES.CATEGORIA)
                result = obtenerCATEGORIA();
            return result;
        }

        private string obtenerCATEGORIA()
        {
            try
            {
                if (tarifa != null && tarifa.ID > 0)
                {
                    TARIFACATEGORIAManagement tARIFACATEGORIAManagement = new TARIFACATEGORIAManagement();
                    TARIFACATEGORIA tARIFACATEGORIA = new TARIFACATEGORIA();
                    tARIFACATEGORIA.ID = tarifa.ID_TARIFA_CATEGORIA;
                    tARIFACATEGORIA = tARIFACATEGORIAManagement.buscarPrimeroTARIFACATEGORIA(tARIFACATEGORIA);
                    if (tARIFACATEGORIA != null && tARIFACATEGORIA.ID > 0)
                        return tARIFACATEGORIA.NOMBRE;
                    else
                        return "";
                }
                else
                    return "";
            }
            catch (Exception exp)
            {
                return "";
            }
        }

        private string obtenerEDAD()
        {
            try
            {
                if (cliente != null && cliente.ID > 0)
                {
                    DateTime fechaNacimiento = cliente.FECHA_NACIMIENTO;
                    int edad = (DateTime.Now.Subtract(fechaNacimiento).Days / 365);
                    return edad.ToString();
                }
                else
                    return "";
            }
            catch (Exception exp)
            {
                return "";
            }
        }

        private string obtenerSEXO()
        {
            try
            {
                if (cliente != null && cliente.ID > 0)
                {
                    GENEROManagement gENEROManagement = new GENEROManagement();
                    GENERO gENERO = new GENERO();
                    gENERO.ID = cliente.ID_GENERO;
                    gENERO = gENEROManagement.buscarPrimeroGENERO(gENERO);
                    if (gENERO != null && gENERO.ID > 0)
                        return gENERO.NOMBRE;
                    else
                        return "";
                }
                else
                    return "";
            }
            catch (Exception exp)
            {
                return "";
            }
        }

        public enum VARIABLES { SEXO, EDAD, CATEGORIA }
    }
}