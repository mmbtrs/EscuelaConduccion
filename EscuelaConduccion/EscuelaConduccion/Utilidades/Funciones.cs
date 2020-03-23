using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscuelaConduccion.Utilidades
{
    public static class Funciones
    {
        public static void setFocus(Control ctrl, KeyPressEventArgs tecla)
        {
            if ((int)tecla.KeyChar == (int)Keys.Enter)
            {
                ctrl.Focus();
            }
        }

        public static bool isEnter(KeyPressEventArgs tecla)
        {
            if ((int)tecla.KeyChar == (int)Keys.Enter)
                return true;
            else
                return false;
        }

        public static bool validarEmail(string email)
        {
            return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        public enum operation
        {
            EDITAR, CREAR, VER
        }

        public static void esNumero(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == '\b'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void esAlfanumerico(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsLetter(e.KeyChar) || (e.KeyChar == '\b'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void esDecimal(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == '\b') || (e.KeyChar == ',') || (e.KeyChar == '.'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void esLetra(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || (e.KeyChar == '\b'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
