using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ProyectoLDEC
{
    internal class Lista
    {
        // Creo el nodo inicio 
        private Nodo nodoInicio;
        public Lista()
        {
            // Inicializo el primer nodo y sus apuntadores dirigen hacia el mismo
            // ya que todavia no tiene mas nodos a los cuales apuntar
            nodoInicio = new Nodo();
            nodoInicio.Siguiente = nodoInicio;
            nodoInicio.Anterior = nodoInicio;
        }


        // --------- METODO LISTA VACIA (confirma si la lista esta o no vacia)


        private bool listaVacia()
        {
            return nodoInicio.Siguiente == nodoInicio;
        }


        // ---------- METODO AGREGAR DATOS A LA LISTA --------------


        public void Agregar(string dato)
        {
            // Creo un nuevo nodo y al cual al asignarle un dato, llegara a la variable dato
            Nodo nuevoNodo = new Nodo();
            nuevoNodo.Dato = dato;

            // El ultimo nodo sera al que mi enlace del nodo inicial conducira
            Nodo ultimoNodo = nodoInicio.Anterior;

            // El enlace siguiente de mi nuevoNodo conducira al nodo de inicio,
            // mientras que el enlace anterior del nuevoNodo conducira al ultimo ndo
            nuevoNodo.Siguiente = nodoInicio;
            nuevoNodo.Anterior = ultimoNodo;

            // El enlace siguiente de mi ultimoNodo conducira al nuevoNodo,
            // mientras que el enlace anterior del nodo inicial conducira a mi nuevo nodo
            ultimoNodo.Siguiente = nuevoNodo;
            nodoInicio.Anterior = nuevoNodo;
        }

        
        // ---------- METODO IMPRESION DE LISTA --------------


        public void Imprimir()
        {
            if (listaVacia())
            {
                Console.WriteLine("La lista se encuentra vacia");
                return;
            }

            Nodo nodoActual = nodoInicio.Siguiente;

            while (nodoActual != nodoInicio)
            {
                Console.Write("[" + nodoActual.Dato + "]");


                if (nodoActual.Siguiente != nodoInicio)
                {
                    Console.Write(" <-> ");
                }

                nodoActual = nodoActual.Siguiente;
            }

            Console.WriteLine("");
        }


        // ---------- METODO ELIMINAR --------------


        public void Eliminar(string dato)
        {
            if (listaVacia())
            {
                Console.WriteLine("La lista esta vacia");
                return;
            }

            Nodo nodoActual = nodoInicio.Siguiente;

            while (nodoActual != nodoInicio)
            {
                if (nodoActual.Dato == dato)
                {
                    nodoActual.Anterior.Siguiente = nodoActual.Siguiente;
                    nodoActual.Siguiente.Anterior = nodoActual.Anterior;

                    return;
                }
                nodoActual = nodoActual.Siguiente;
            }
        }


        // ---------- METODO BUSCAR --------------

        public Nodo Buscar(string dato)
        {
            if (listaVacia())
            {
                Console.WriteLine("La lista esta vacia");
                return null;
            }

            Nodo nodoActual = nodoInicio;
            while (nodoActual.Siguiente != nodoInicio)
            {
                nodoActual = nodoActual.Siguiente;

                if (nodoActual.Dato == dato)
                {
                    Console.WriteLine("Dato encontrado: " + nodoActual.Dato);
                    return nodoActual;
                }
            }
            Console.WriteLine("Dato no encontrado");
            return null;
        }
    }
}
