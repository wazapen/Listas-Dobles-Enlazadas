using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lista_Doble_Enlazada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Inventario inventario = new Inventario();
        Producto producto;

        private void limpiarTextBoxes()
        {
            txtNombre.Clear();
            txtCódigo.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            producto = new Producto();
            producto.producto(txtNombre.Text, Convert.ToInt32(txtCódigo.Text), Convert.ToInt32(txtCantidad.Text), Convert.ToDouble(txtPrecio.Text));
            inventario.agregar(producto);
            limpiarTextBoxes();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtCódigo.Text == "")
                MessageBox.Show("Ingresa el código del producto a borrar");
            else
                inventario.borrar(Convert.ToInt32(txtCódigo.Text));
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtCódigo.Text == "" || txtNombre.Text == "" || txtCantidad.Text == "" || txtPrecio.Text == "")
                MessageBox.Show("Llena los campos vacios");
            else
            {
                producto = new Producto();
                producto.producto(txtNombre.Text, Convert.ToInt32(txtCódigo.Text), Convert.ToInt32(txtCantidad.Text), Convert.ToDouble(txtPrecio.Text));
                inventario.insertarEnPos(producto, Convert.ToInt32(txtPosición.Text));
                limpiarTextBoxes();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Producto temp = inventario.buscar(Convert.ToInt32(txtCódigo.Text));
            if (txtCódigo.Text == "")
                MessageBox.Show("Ingresa el código del producto a buscar");
            else
               if (temp != null)
                txtReporte.Text = temp.ToString();
            else
                txtReporte.Text = "No se encontró";
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtReporte.Clear();
            txtReporte.Text = inventario.reporte();
        }

        private void btnReporteInverso_Click(object sender, EventArgs e)
        {
            txtReporte.Clear();
            txtReporte.Text = inventario.reporteInverso();
        }

        private void btnAgregarEnInicio_Click(object sender, EventArgs e)
        {
            if (txtCódigo.Text == "" || txtNombre.Text == "" || txtCantidad.Text == "" || txtPrecio.Text == "")
                MessageBox.Show("Llena los campos vacios");
            else
            {
                producto = new Producto();
                producto.producto(txtNombre.Text, Convert.ToInt32(txtCódigo.Text), Convert.ToInt32(txtCantidad.Text), Convert.ToDouble(txtPrecio.Text));
                inventario.agregarEnInicio(producto);
                limpiarTextBoxes();
            }
        }

        private void btnBorrarPrimero_Click(object sender, EventArgs e)
        {
            inventario.borrarPrimero();
        }

        private void btnBorrarÚltimo_Click(object sender, EventArgs e)
        {
            inventario.borrarÚltimo();
        }
    }
}
