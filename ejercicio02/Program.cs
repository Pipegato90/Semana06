using System;

// Definición de la clase Nodo
public class Nodo
{
    public int dato;
    public Nodo siguiente;

    public Nodo(int valor)
    {
        dato = valor;
        siguiente = null; // Inicialmente no apunta a ningún otro nodo
    }
}

// Definición de la clase ListaEnlazada
public class ListaEnlazada
{
    private Nodo cabeza; // La referencia al primer nodo de la lista

    public ListaEnlazada()
    {
        cabeza = null; // La lista inicia vacía
    }

    // Método para agregar un nuevo nodo al final de la lista
    public void Agregar(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);
        if (cabeza == null)
        {
            cabeza = nuevoNodo; // Si la lista está vacía, el nuevo nodo es la cabeza
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.siguiente != null)
            {
                actual = actual.siguiente; // Recorre hasta el último nodo
            }
            actual.siguiente = nuevoNodo; // El último nodo apunta al nuevo nodo
        }
        Console.WriteLine($"Se agregó el dato: {valor}");
    }

    // Método para buscar un dato y retornar el número de veces que aparece
    public int BuscarYContar(int valorBuscado)
    {
        int contador = 0;
        Nodo actual = cabeza;

        while (actual != null)
        {
            if (actual.dato == valorBuscado)
            {
                contador++; // Incrementa el contador si encuentra el dato
            }
            actual = actual.siguiente; // Avanza al siguiente nodo
        }

        if (contador > 0)
        {
            Console.WriteLine($"El dato {valorBuscado} se encontró {contador} vez(es) en la lista.");
        }
        else
        {
            Console.WriteLine($"El dato {valorBuscado} no fue encontrado en la lista.");
        }

        return contador; // Retorna el número de veces que se encontró el dato
    }

    // Método para mostrar todos los elementos de la lista (opcional, para depuración)
    public void MostrarLista()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Console.Write("Elementos de la lista: ");
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write($"{actual.dato} ");
            actual = actual.siguiente;
        }
        Console.WriteLine();
    }
}

// Clase principal para probar la implementación
public class Programa
{
    public static void Main(string[] args)
    {
        ListaEnlazada miLista = new ListaEnlazada();

        // Agregando elementos a la lista
        miLista.Agregar(10);
        miLista.Agregar(20);
        miLista.Agregar(10);
        miLista.Agregar(30);
        miLista.Agregar(10);
        miLista.Agregar(40);
        miLista.Agregar(20);

        miLista.MostrarLista(); // Mostrar la lista completa

        Console.WriteLine("\n--- Realizando búsquedas ---");

        // Casos de prueba para el método BuscarYContar
        miLista.BuscarYContar(10); // Busca un dato que existe varias veces
        miLista.BuscarYContar(20); // Busca un dato que existe dos veces
        miLista.BuscarYContar(30); // Busca un dato que existe una vez
        miLista.BuscarYContar(50); // Busca un dato que no existe

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}