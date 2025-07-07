public class ListaEnlazada
{
    public Nodo Cabeza { get; private set; } // El primer nodo de la lista

    public ListaEnlazada()
    {
        Cabeza = null; // Inicialmente, la lista está vacía
    }

    /// <summary>
    /// Agrega un nuevo nodo al final de la lista.
    /// </summary>
    public void Agregar(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);
        if (Cabeza == null)
        {
            Cabeza = nuevoNodo; // Si la lista está vacía, el nuevo nodo es la cabeza
        }
        else
        {
            Nodo actual = Cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente; // Recorre hasta el último nodo
            }
            actual.Siguiente = nuevoNodo; // Agrega el nuevo nodo al final
        }
    }

    /// <summary>
    /// Calcula y devuelve la longitud (número de nodos) de la lista enlazada.
    /// </summary>
    public int CalcularLongitud()
    {
        int contador = 0;      // Inicializamos el contador en cero
        Nodo actual = Cabeza;  // Empezamos desde la cabeza de la lista

        // Recorremos la lista mientras el nodo actual no sea nulo
        while (actual != null)
        {
            contador++;          // Incrementamos el contador por cada nodo
            actual = actual.Siguiente; // Saltamos al siguiente nodo
        }

        return contador; // Devolvemos el total de nodos contados
    }

    /// <summary>
    /// Imprime los valores de todos los nodos en la lista.
    /// </summary>
    public void ImprimirLista()
    {
        Nodo actual = Cabeza;
        if (actual == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }
        while (actual != null)
        {
            Console.Write(actual.Valor + " ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }
}