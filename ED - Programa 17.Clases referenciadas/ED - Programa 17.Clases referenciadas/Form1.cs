using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED___Programa_17.Clases_referenciadas
{
    public partial class Form1 : Form
    {
        Inventario inventario = new Inventario();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto(txtCodigo.Text, txtNombre.Text, int.Parse(txtCantidad.Text), Convert.ToSingle(txtPrecio.Text));
            inventario.agregar(producto);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            inventario.borrar(txtCodigo.Text);
        }

        private void btnEnInicio_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto(txtCodigo.Text, txtNombre.Text, int.Parse(txtCantidad.Text), Convert.ToSingle(txtPrecio.Text));
            inventario.agregarInicio(producto);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto(txtCodigo.Text, txtNombre.Text, int.Parse(txtCantidad.Text), Convert.ToSingle(txtPrecio.Text));
            inventario.insertar(producto, int.Parse(txtPosicion.Text));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (inventario.buscar(txtCodigo.Text) != null)
                txtMostrar.Text = inventario.buscar(txtCodigo.Text).ToString();
            else
                txtMostrar.Text = "No se encontró ese producto";
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = inventario.reporte();
        }
    }
}
