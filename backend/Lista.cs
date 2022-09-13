using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend
{
    public class Lista
    {
        public string[] Nombres { get; set; } = new string[0];

        public void Agregar(string nombre)
        {
            Redimensionar();
            Nombres[Nombres.Length - 1] = nombre;
        }

        public void Modificar(int fila, string nombre)
        {

        }

        public bool Modificar(string nombreOriginal, string nombreNuevo)
        {
            bool res = false;


            return res;
        }

        public int Buscar(string nombre)
        {
            int fila = -1;   

            return fila;
        }

        public bool Eliminar(int fila)
        {
            bool res = false;

            return res;
        }

        public bool Eliminar(string nombreABorrar)
        {
            bool res = false;

            return res;
        }

        private void Redimensionar()
        {
            string[] pepe = new string[Nombres.Length + 1];
            int i = 0;  
            
            foreach (string nombre in Nombres)
            {
                pepe[i] = nombre;
                i = i + 1;
            }
            Nombres = pepe;
        }
    }
}
