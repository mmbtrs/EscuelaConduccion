using EscuelaConduccion.Utilidades;
using EscuelaConduccion.wsServiciosACUERDO_ESTADO;
using EscuelaConduccion.wsServiciosACUERDO_PAGO;
using EscuelaConduccion.wsServiciosACUERDO_PAGO_DETALLE;
using EscuelaConduccion.wsServiciosLIQUIDACION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilidadesServiciosWeb;

namespace EscuelaConduccion.Modelo.Liquidacion
{
    public partial class frmCreacionCuotas : Form
    {
        ServiciosLIQUIDACION serviciosLIQUIDACION;
        ServiciosACUERDO_PAGO serviciosACUERDO_PAGO;
        ServiciosACUERDO_PAGO_DETALLE serviciosACUERDO_PAGO_DETALLE;
        ServiciosACUERDO_ESTADO serviciosACUERDO_ESTADO;

        double totalDeuda;
        LIQUIDACION myLiquidacion;

        public frmCreacionCuotas(int id_liquidacion)
        {
            InitializeComponent();
            serviciosLIQUIDACION = (ServiciosLIQUIDACION)Configurador.ConfigurarServicio(typeof(ServiciosLIQUIDACION));
            serviciosACUERDO_PAGO = (ServiciosACUERDO_PAGO)Configurador.ConfigurarServicio(typeof(ServiciosACUERDO_PAGO));
            serviciosACUERDO_PAGO_DETALLE = (ServiciosACUERDO_PAGO_DETALLE)Configurador.ConfigurarServicio(typeof(ServiciosACUERDO_PAGO_DETALLE));
            serviciosACUERDO_ESTADO = (ServiciosACUERDO_ESTADO)Configurador.ConfigurarServicio(typeof(ServiciosACUERDO_ESTADO));
            getLiquidacion(id_liquidacion);
        }

        private void getLiquidacion(int id_liquidacion)
        {
            try
            {
                myLiquidacion = new LIQUIDACION();
                myLiquidacion.ID = id_liquidacion;
                myLiquidacion = serviciosLIQUIDACION.buscarPrimeroLIQUIDACION(myLiquidacion);
                if (myLiquidacion != null && myLiquidacion.ID > 0)
                {
                    lblDeuda.Text = "$" + myLiquidacion.TOTAL;
                    totalDeuda = myLiquidacion.TOTAL;
                }
                else
                {
                    lblDeuda.Text = "$0";
                    totalDeuda = 0;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Se presento el error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myLiquidacion = null;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.esNumero(e);
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.esNumero(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.esNumero(e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calcularCuotas();
        }

        private void calcularCuotas()
        {
            if (validarCampos())
            {
                if (totalDeuda > 0)
                {
                    int numcuotas = int.Parse(txtCantidad.Text);
                    if (rarEspecificar.Checked)
                    {
                        double valorPrimeraCuota = double.Parse(txtEspecificar.Text);
                        if (valorPrimeraCuota <= 0)
                        {
                            MessageBox.Show("La primera cuota no puede ser cero ni menor que cero", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtEspecificar.Focus();
                        }
                        else
                        {
                            if (valorPrimeraCuota >= totalDeuda)
                            {
                                MessageBox.Show("La primera cuota no puede ser mayor ni igual al total de la deuda", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtEspecificar.Focus();
                            }
                            else
                            {
                                double valorCuotas = (totalDeuda - valorPrimeraCuota) / (numcuotas - 1);
                                double porcentajePrimeraCuota = (valorPrimeraCuota * 100) / totalDeuda;
                                double porcentajeCuota = (valorCuotas * 100) / totalDeuda;

                                DateTime fecha = DateTime.Now;
                                grdDatos.Rows.Clear();
                                grdDatos.Rows.Add(1, valorPrimeraCuota, porcentajePrimeraCuota.ToString() + "%", fecha);
                                for (int i = 1; i < numcuotas; i++)
                                {
                                    grdDatos.Rows.Add(i + 1, valorCuotas, porcentajeCuota.ToString() + "%", fecha = fecha.AddMonths(1));
                                }
                            }
                        }
                    }
                    else //porcentaje
                    {
                        if (double.Parse(txtPorcentaje.Text) <= 0)
                        {
                            MessageBox.Show("El porcentaje de la primera cuota no puede ser 0% ni menor que 0%", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPorcentaje.Focus();
                        }
                        else
                        {
                            if (double.Parse(txtPorcentaje.Text) >= 100)
                            {
                                MessageBox.Show("La primera cuota no puede ser mayor ni igual al 100% del total de la deuda", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtPorcentaje.Focus();
                            }
                            else
                            {
                                double porcentajePrimeraCuota = double.Parse(txtPorcentaje.Text);
                                double valorPrimeraCuota = (totalDeuda * porcentajePrimeraCuota) / 100;
                                double valorCuotas = (totalDeuda - valorPrimeraCuota) / (numcuotas - 1);
                                
                                double porcentajeCuota = (valorCuotas * 100) / totalDeuda;

                                DateTime fecha = DateTime.Now;
                                grdDatos.Rows.Clear();
                                grdDatos.Rows.Add(1, valorPrimeraCuota, porcentajePrimeraCuota.ToString() + "%", fecha);
                                for (int i = 1; i < numcuotas; i++)
                                {
                                    grdDatos.Rows.Add(i + 1, valorCuotas, porcentajeCuota.ToString() + "%", fecha = fecha.AddMonths(1));
                                }
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("El valor de la deuda es cero (0)", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool validarCampos()
        {
            try
            {
                if (!(!String.IsNullOrEmpty(txtCantidad.Text) && !String.IsNullOrWhiteSpace(txtCantidad.Text)))
                {
                    MessageBox.Show("Debe digitar la cantidad de cuotas", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCantidad.Focus();
                    return false;
                }
                else
                {
                    if (rarPorcentaje.Checked)
                    {
                        if (!(!String.IsNullOrEmpty(txtPorcentaje.Text) && !String.IsNullOrWhiteSpace(txtPorcentaje.Text)))
                        {
                            MessageBox.Show("Debe digitar el porcentaje de la primera cuota", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtPorcentaje.Focus();
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if (!(!String.IsNullOrEmpty(txtEspecificar.Text) && !String.IsNullOrWhiteSpace(txtEspecificar.Text)))
                        {
                            MessageBox.Show("Debe especificar el valor de la primera cuota", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtEspecificar.Focus();
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ocurrio el siguiente error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            crearAcuerdoYDetalle();
        }

        private void crearAcuerdoYDetalle()
        {
            try
            {
                if (totalDeuda > 0 && myLiquidacion != null && myLiquidacion.ID > 0)
                {
                    ACUERDO_PAGO acuerdo = crearAcuerdoPago();
                    if (acuerdo != null && acuerdo.ID > 0)
                    {
                        if (crearACUERDO_PAGO_DETALLE(acuerdo))
                        {
                            frmAcuerdoPago frm = new frmAcuerdoPago(acuerdo);
                            frm.ShowDialog(this);
                        }
                        else
                            MessageBox.Show("Se presentó un error y no fue posible generar las cuotas del acuerdo de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Se presentó un error y no fue posible generar el acuerdo de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Se presentó el siguiente error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool crearACUERDO_PAGO_DETALLE(ACUERDO_PAGO acuerdo)
        {
            try
            {
                ACUERDO_PAGO_DETALLE[] lstDetalle = new ACUERDO_PAGO_DETALLE[grdDatos.Rows.Count];
                int i = 0;
                foreach (DataGridViewRow fila in grdDatos.Rows)
                {
                    ACUERDO_PAGO_DETALLE detalle = new ACUERDO_PAGO_DETALLE();
                    detalle.FECHA_LIMITE_PAGO = DateTime.Parse(fila.Cells["FECHA_LIMITE"].Value.ToString());
                    detalle.ID_ACUERDO_PAGO = acuerdo.ID;
                    detalle.NUMERO_CUOTA = int.Parse(fila.Cells["CUOTA"].Value.ToString());
                    string porcentaje = fila.Cells["PORCENTAJE"].Value.ToString().Remove(fila.Cells["PORCENTAJE"].Value.ToString().Length - 1, 1);
                    detalle.PORCENTAJE = float.Parse(porcentaje);
                    detalle.VALOR = float.Parse(fila.Cells["VALOR"].Value.ToString());
                    lstDetalle[i] = detalle;
                    i++;
                }
                return serviciosACUERDO_PAGO_DETALLE.crearACUERDO_PAGO_DETALLE_Masivo(lstDetalle);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Se presentó el siguiente error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private ACUERDO_PAGO crearAcuerdoPago()
        {
            try
            {
                ACUERDO_PAGO acuerdo = new ACUERDO_PAGO();
                acuerdo.FECHA_ACUERDO = datFechaCreacion.Value.Date;
                ACUERDO_ESTADO estado = new ACUERDO_ESTADO();
                estado.NOMBRE = "VIGENTE";
                estado = serviciosACUERDO_ESTADO.buscarPrimeroACUERDO_ESTADO(estado);
                if (estado != null && estado.ID > 0)
                    acuerdo.ID_ACUERDO_ESTADO = estado.ID;
                else
                    acuerdo.ID_ACUERDO_ESTADO = 1;
                acuerdo.ID_LIQUIDACION = myLiquidacion.ID;
                return serviciosACUERDO_PAGO.crearACUERDO_PAGO(acuerdo);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Se presentó el siguiente error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
