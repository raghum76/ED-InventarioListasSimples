using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED___Programa_17.Clases_referenciadas
{
    class Inventario
    {
        private Producto _inicio;

        public void agregar(Producto producto)
        {
            if (_inicio == null)
                _inicio = producto;
            else
            {
                Producto auxiliar = _inicio;
                while (auxiliar.siguiente != null)
                    auxiliar = auxiliar.siguiente;
                auxiliar.siguiente = producto;
            }
        }

        public void agregarInicio(Producto producto)
        {
            producto.siguiente = _inicio;
            _inicio = producto;
        }

        public Producto buscar(string codigo)
        {
            Producto auxiliar = _inicio;
            while (auxiliar.siguiente != null && codigo != auxiliar.codigo)
                auxiliar = auxiliar.siguiente;
            if (auxiliar.codigo == codigo)
                return auxiliar;
            else
                return null;
        }

        public void borrar(string codigo)
        {
            Producto auxiliar = _inicio;
            if (_inicio.codigo == codigo)
                _inicio = _inicio.siguiente;
            else
            {
                while (auxiliar.siguiente != null && codigo != auxiliar.siguiente.codigo)
                    auxiliar = auxiliar.siguiente;
                if (auxiliar.siguiente != null)
                    auxiliar.siguiente = auxiliar.siguiente.siguiente; 
            }
        }

        public void insertar(Producto producto, int posicion)
        {
            if (posicion == 0)
                agregarInicio(producto);
            else
            {
                Producto auxiliar = _inicio;
                for (int i = 0; i < posicion - 1; i++)
                    auxiliar = auxiliar.siguiente;
                producto.siguiente = auxiliar.siguiente;
                auxiliar.siguiente = producto;
            }
        }

        public string reporte()
        {
            if (_inicio == null)
                return "No hay productos";
            else
            {
                string cadena = "";
                Producto auxiliar = _inicio;
                while (auxiliar.siguiente != null)
                {
                    cadena += auxiliar.ToString() + Environment.NewLine;
                    auxiliar = auxiliar.siguiente;
                }
                cadena += auxiliar.ToString() + Environment.NewLine;
                return cadena;
            }
        }
    }
}
