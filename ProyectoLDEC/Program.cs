namespace ProyectoLDEC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creo la lista
            Lista lista = new Lista();

            // Empiezo agregando datos a la lista y los imprimo
            // (testeo de lista.Agregar y lista.Imprimir)
            lista.Agregar("A");
            lista.Agregar("B");
            lista.Agregar("C");
            lista.Agregar("D");
            lista.Imprimir();

            // Eliminacion de datos en la lista (testeo de lista.Eliminar)
            lista.Eliminar("C");
            lista.Imprimir();
            lista.Eliminar("A");
            lista.Eliminar("B");
            lista.Eliminar("D");
            lista.Imprimir();

            // Testeo de busqueda de datos en la lista (testeo de lista.Buscar)
            lista.Agregar("A");
            lista.Agregar("B");
            lista.Agregar("C");
            lista.Agregar("D");
            lista.Imprimir();
            lista.Buscar("D");
            lista.Buscar("E");
            lista.Imprimir();
            lista.Agregar("A");
        }
    }
}
