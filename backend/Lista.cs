using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
            int pepita = Buscar(nombreOriginal);
            if (pepita != -1)
            {
                Nombres[pepita] = nombreNuevo;
                res = true;
            }
            return res;
        }

        public int Buscar(string nombre)
        {
            int fila = -1;
            for (int  i= 0; i < Nombres.Length; i++)
            {
                if (Nombres[i] == nombre)
                {
                    fila = i;
                    break;
                }
            }
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

        public string Salida()
        {
            string res = "";

            foreach (string item in Nombres)
            {
                res = res + item + "\r\n";
            }

            //for (int i = 0; i < Nombres.Length; i++)
            //{
            //    Nombres[i]
            //}

            //int i = 0;
            //while (i<Nombres.Length)
            //{
            //    Nombres[i]
            //    i= i + 1;
            //}

            //do
            //{
            //    Nombres[i]
            //    i = i + 1;
            //} while (i < Nombres.Length);

            return res;
        }

        private void Redimensionar()
        {
            string[] pepe = new string[Nombres.Length + 1];
            int i = 0;  
            
            foreach (string item in Nombres)
            {
                pepe[i] = item;
                i = i + 1;
            }
            Nombres = pepe;
        }
    }
}
