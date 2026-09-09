using System;
using System.Collections.Generic;
using System.Text;

namespace Colas_enlazadas
{
    public class Colaenlazada
    {
        public Nodo Primero;
        public Nodo Ultimo;
        public Colaenlazada()
        {
            Primero = null;
            Ultimo = null;
        }
        public bool EstaVacia()
        {
            return Primero == null;
        }
        public void Encolar(string d)
        {
            Nodo x = new Nodo(d);
            if (Primero == null)
            {
                Primero = x;
            }
            else
            {
                Ultimo.Siguiente = x;
            }
            Ultimo = x;
        }
        public string Desencolar()
        {
            if (EstaVacia())
            {
                return null;
            }
            string d = Primero.Dato;
            Nodo x = Primero;
            Primero = Primero.Siguiente;
            if (Primero == null)
            {
                Ultimo = null;
            }
            x = null;
            return d;
        }
        public void Mostrar()
        {
            Nodo x = Primero;
            while (x != null)
            {
                Console.WriteLine(x.Dato);
                x = x.Siguiente;
            }
        }
    }
}
