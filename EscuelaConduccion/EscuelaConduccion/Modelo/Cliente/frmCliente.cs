using EscuelaConduccion.Modelo.Accesorias;
using EscuelaConduccion.Utilidades;
using EscuelaConduccion.wsServiciosCLIENTE;
using EscuelaConduccion.wsServiciosGENERO;
using EscuelaConduccion.wsServiciosTIPO_DOCUMENTO;
using EscuelaConduccion.wsServiciosVIEW_CIUDAD;
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
using static EscuelaConduccion.Utilidades.Funciones;

namespace EscuelaConduccion.Modelo.Cliente
{
    public partial class frmCliente : Form
    {
        ServiciosTIPO_DOCUMENTO serviciosTIPO_DOCUMENTO;
        ServiciosGENERO serviciosGENERO;
        GENERO myGenero;
        VIEW_CIUDAD myCiudad;
        ServiciosCLIENTE serviciosCLIENTE;
        ServiciosVIEW_CIUDAD serviciosVIEW_CIUDAD;
        CLIENTE myCliente;
        operation operacion;

        public frmCliente(CLIENTE cliente, operation operacion)
        {
            InitializeComponent();
            serviciosTIPO_DOCUMENTO = (ServiciosTIPO_DOCUMENTO)Configurador.ConfigurarServicio(typeof(ServiciosTIPO_DOCUMENTO));
            serviciosGENERO = (ServiciosGENERO)Configurador.ConfigurarServicio(typeof(ServiciosGENERO));
            serviciosCLIENTE = (ServiciosCLIENTE)Configurador.ConfigurarServicio(typeof(ServiciosCLIENTE));
            serviciosVIEW_CIUDAD = (ServiciosVIEW_CIUDAD)Configurador.ConfigurarServicio(typeof(ServiciosVIEW_CIUDAD));
            myCliente = cliente;
            this.operacion = operacion;
            getTiposDocumento();
            getGeneros();
            cargarDatos();
        }

        public void setComboGenero(int id)
        {
            int indice = 0;
            foreach (GENERO item in cmbGenero.Items)
            {
                if (item.ID == id)
                {
                    break;
                }
                indice++;
            }
            cmbGenero.SelectedIndex = indice;
        }

        public void setComboTipoDocumento(int id)
        {
            int indice = 0;
            foreach (TIPO_DOCUMENTO item in cmbTipoDocumento.Items)
            {
                if (item.ID == id)
                {
                    break;
                }
                indice++;
            }
            cmbTipoDocumento.SelectedIndex = indice;
        }

        private void getTiposDocumento()
        {
            try
            {
                TIPO_DOCUMENTO[] lstTipos = serviciosTIPO_DOCUMENTO.listarTIPO_DOCUMENTO();
                if (lstTipos != null && lstTipos.Length > 0)
                {
                    cmbTipoDocumento.Items.Clear();
                    foreach (TIPO_DOCUMENTO item in lstTipos)
                    {
                        cmbTipoDocumento.Items.Add(item);
                    }
                    cmbTipoDocumento.SelectedIndex = 0;
                }
            }
            catch (Exception exp)
            {
            }
        }

        private void getGeneros()
        {
            try
            {
                GENERO[] lstGeneros = serviciosGENERO.listarGENERO();
                if (lstGeneros != null && lstGeneros.Length > 0)
                {
                    cmbGenero.Items.Clear();
                    foreach (GENERO item in lstGeneros)
                    {
                        cmbGenero.Items.Add(item);
                    }
                    cmbGenero.SelectedIndex = 0;
                }
            }
            catch (Exception exp)
            {
            }
        }

        private void cargarDatos()
        {
            try
            {
                switch (operacion)
                {
                    case operation.EDITAR:
                        this.Text = "Editar Cliente";
                        cmbTipoDocumento.Enabled = false;
                        txtNumDocumento.ReadOnly = true;
                        btnGuardar.Visible = true;
                        btnBuscarCiudad.Enabled = true;
                        loadCliente();
                        break;
                    case operation.CREAR:
                        this.Text = "Nuevo Cliente";
                        cmbTipoDocumento.Enabled = true;
                        txtNumDocumento.ReadOnly = false;
                        btnBuscarCiudad.Enabled = true;
                        btnGuardar.Visible = true;
                        break;
                    case operation.VER:
                        this.Text = "Información del Cliente";
                        cmbTipoDocumento.Enabled = true;
                        txtNumDocumento.ReadOnly = false;
                        btnGuardar.Visible = false;
                        btnBuscarCiudad.Enabled = false;
                        loadCliente();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception exp)
            {
            }
        }

        private void loadCliente()
        {
            try
            {
                if (myCliente != null && myCliente.ID > 0)
                {
                    myCliente = serviciosCLIENTE.buscarPrimeroCLIENTE(myCliente);
                    if (myCliente != null && myCliente.ID > 0)
                    {
                        setComboTipoDocumento(myCliente.ID_TIPO_DOCUMENTO);
                        txtNumDocumento.Text = myCliente.IDENTIFICACION;
                        txtNombres.Text = myCliente.NOMBRES;
                        txtApellidos.Text = myCliente.APELLIDOS;
                        txtDireccion.Text = myCliente.DIRECCION;
                        myCiudad = new VIEW_CIUDAD();
                        myCiudad.ID = myCliente.ID_CIUDAD;
                        myCiudad = serviciosVIEW_CIUDAD.buscarPrimeroVIEW_CIUDAD(myCiudad);
                        if (myCiudad != null && myCiudad.ID > 0)
                        {
                            txtCiudad.Text = myCiudad.CIUDAD;
                            txtDepartamento.Text = myCiudad.DEPARTAMENTO;
                        }
                        txtCelular.Text = myCliente.CELULAR;
                        txtTelefono.Text = myCliente.TELEFONO;
                        txtCorreo.Text = myCliente.CORREO;
                        datFechaNacimiento.Value = myCliente.FECHA_NACIMIENTO;
                        setComboGenero(myCliente.ID_GENERO);
                    }
                }
            }
            catch (Exception exp)
            {
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                if (operacion == operation.CREAR)
                {
                    crearCliente();
                }
                else
                {
                    if (operacion == operation.EDITAR)
                    {
                        editarCliente();
                    }
                }
            }
        }

        private bool validarCampos()
        {
            if (cmbTipoDocumento.SelectedItem != null && cmbTipoDocumento.SelectedIndex >= 0)
            {
                if (!String.IsNullOrEmpty(txtNumDocumento.Text) && !String.IsNullOrWhiteSpace(txtNumDocumento.Text))
                {
                    if (!String.IsNullOrEmpty(txtNombres.Text) && !String.IsNullOrWhiteSpace(txtNombres.Text))
                    {
                        if (!String.IsNullOrEmpty(txtApellidos.Text) && !String.IsNullOrWhiteSpace(txtApellidos.Text))
                        {
                            if (!String.IsNullOrEmpty(txtDireccion.Text) && !String.IsNullOrWhiteSpace(txtDireccion.Text))
                            {
                                if (myCiudad != null && myCiudad.ID > 0)
                                {
                                    if (Funciones.validarEmail(txtCorreo.Text.Trim()))
                                    {
                                        if (datFechaNacimiento.Value.Date.CompareTo(DateTime.Now.Date) < 0)
                                        {
                                            if (cmbGenero.SelectedItem != null && cmbGenero.SelectedIndex >= 0)
                                            {
                                                CLIENTE tmpCliente = new CLIENTE();
                                                tmpCliente.ID_TIPO_DOCUMENTO = ((TIPO_DOCUMENTO)cmbTipoDocumento.SelectedItem).ID;
                                                tmpCliente.IDENTIFICACION = txtNumDocumento.Text.Trim();
                                                CLIENTE[] lstTemporal = serviciosCLIENTE.buscarCLIENTE(tmpCliente);
                                                if (operacion == operation.CREAR)
                                                {
                                                    if (lstTemporal == null || lstTemporal.Length < 1)
                                                        return true;
                                                    else
                                                    {
                                                        MessageBox.Show("Ya existe un cliente, con el mismo tipo de documento y el mismo número de identificación, registrado en la base de datos", "Cliente duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        txtNumDocumento.Focus();
                                                        return false;
                                                    }
                                                }
                                                else
                                                {
                                                    if (operacion == operation.EDITAR)
                                                    {
                                                        if (lstTemporal != null && lstTemporal.Length == 1)
                                                            return true;
                                                        else
                                                        {
                                                            MessageBox.Show("No se encontró el cliente, que desea editar, en la base de datos", "Cliente duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            txtNombres.Focus();
                                                            return false;
                                                        }
                                                    }
                                                }
                                                return true;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Debe seleccionar el genero del cliente", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                cmbGenero.Focus();
                                                return false;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("La fecha de nacimiento del cliente no puede ser mayor o igual a la fecha actual", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            datFechaNacimiento.Focus();
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Debe digitar una dirección de correo electrónico valida", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtCorreo.Focus();
                                        return false;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Debe seleccionar la ciudad de la dirección del cliente", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtCiudad.Focus();
                                    return false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe digitar la dirección del cliente", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtDireccion.Focus();
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe digitar los apellidos del cliente", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtApellidos.Focus();
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe digitar los nombres del cliente", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNombres.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Debe digitar el número de documento", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumDocumento.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar el tipo de documento", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbTipoDocumento.Focus();
                return false;
            }
        }

        private void editarCliente()
        {
            try
            {
                myCliente.APELLIDOS = txtApellidos.Text.Trim();
                myCliente.CELULAR = txtCelular.Text.Trim();
                myCliente.CORREO = txtCorreo.Text.Trim();
                myCliente.DIRECCION = txtDireccion.Text.Trim();
                myCliente.FECHA_NACIMIENTO = datFechaNacimiento.Value.Date;
                myCliente.IDENTIFICACION = txtNumDocumento.Text.Trim();
                myCliente.ID_CIUDAD = myCiudad.ID;
                myCliente.ID_GENERO = ((GENERO)cmbGenero.SelectedItem).ID;
                myCliente.ID_TIPO_DOCUMENTO = ((TIPO_DOCUMENTO)cmbTipoDocumento.SelectedItem).ID;
                myCliente.NOMBRES = txtNombres.Text.Trim();
                myCliente.TELEFONO = txtTelefono.Text.Trim();
                if (serviciosCLIENTE.editarCLIENTE(myCliente))
                {
                    MessageBox.Show("Se actualizó la información del cliente correctamente", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Ocurrió un error inesperado y no fue posible actualizar la información del cliente", "Actualización erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Se presentó el siguiente error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void crearCliente()
        {
            try
            {
                myCliente = new CLIENTE();
                myCliente.APELLIDOS = txtApellidos.Text.Trim();
                myCliente.CELULAR = txtCelular.Text.Trim();
                myCliente.CORREO = txtCorreo.Text.Trim();
                myCliente.DIRECCION = txtDireccion.Text.Trim();
                myCliente.FECHA_NACIMIENTO = datFechaNacimiento.Value.Date;
                myCliente.IDENTIFICACION = txtNumDocumento.Text.Trim();
                myCliente.ID_CIUDAD = myCiudad.ID;
                myCliente.ID_GENERO = ((GENERO)cmbGenero.SelectedItem).ID;
                myCliente.ID_TIPO_DOCUMENTO = ((TIPO_DOCUMENTO)cmbTipoDocumento.SelectedItem).ID;
                myCliente.NOMBRES = txtNombres.Text.Trim();
                myCliente.TELEFONO = txtTelefono.Text.Trim();
                myCliente = serviciosCLIENTE.crearCLIENTE(myCliente);
                if (myCliente != null && myCliente.ID > 0)
                {
                    MessageBox.Show("Se registró la información del cliente correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Ocurrió un error inesperado y no fue posible registrar la información del cliente", "Registro erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Se presentó el siguiente error: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarCiudad_Click(object sender, EventArgs e)
        {
            getMunicipio();
        }

        private void getMunicipio()
        {
            frmMunicipios frm = new frmMunicipios();
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                myCiudad = frm.MyCiudad;
                txtCiudad.Text = myCiudad.CIUDAD;
                txtDepartamento.Text = myCiudad.DEPARTAMENTO;
            }
        }
        
        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (operacion != operation.VER)
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    frmMunicipios frm = new frmMunicipios();
                    if (frm.ShowDialog(this) == DialogResult.OK)
                    {
                        myCiudad = frm.MyCiudad;
                        txtCiudad.Text = myCiudad.CIUDAD;
                        txtDepartamento.Text = myCiudad.DEPARTAMENTO;
                        Funciones.setFocus(txtCelular, e);
                    }
                }
            }
        }

        private void cmbTipoDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.setFocus(txtNumDocumento, e);
        }

        private void txtNumDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.setFocus(txtNombres, e);
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.setFocus(txtApellidos, e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.setFocus(txtDireccion, e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.setFocus(txtCiudad, e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.setFocus(txtTelefono, e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.setFocus(txtCorreo, e);
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.setFocus(datFechaNacimiento, e);
        }

        private void datFechaNacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.setFocus(cmbGenero, e);
        }

        private void cmbGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.setFocus(btnGuardar, e);
        }
    }
}
