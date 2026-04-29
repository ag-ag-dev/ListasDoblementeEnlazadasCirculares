using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoLDEC
{
    internal class Nodo
    {
        // Creando la variable Dato para la insercion de los datos dentro del Nodo
        // y los apuntadores de Siguiente y Anterior para el Nodo
        public string Dato { get; set; }
        public Nodo? Siguiente { get; set; }
        public Nodo? Anterior { get; set; }

        public Nodo(Nodo? anterior = null, string dato = "", Nodo? siguiente = null)
        {
            Anterior = anterior;
            Siguiente = siguiente;
            Dato = dato;
        }
    }
}
