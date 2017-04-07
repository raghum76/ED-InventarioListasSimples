using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED___Programa_17.Clases_referenciadas
{
    class Producto
    {
        private string _codigo;
        public string codigo
        {
            get { return _codigo; }
        }

        private string _nombre;
        private int _cantidad;
        private float _precio;

        private Producto _siguiente;
        public Producto siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public Producto(string codigo, string nombre, int cantidad, float precio)
        {
            _codigo = codigo;
            _nombre = nombre;
            _cantidad = cantidad;
            _precio = precio;
        }

        public override string ToString()
        {
            return _codigo + Environment.NewLine + _nombre + Environment.NewLine + _cantidad + Environment.NewLine + _precio + Environment.NewLine;
        }
    }
}
