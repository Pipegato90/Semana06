using System;

public class Program
{
    public static void Main(string[] args)
    {
        ListaEnlazada miLista = new ListaEnlazada();

        // Agregamos algunos elementos
        miLista.Agregar(10);
        miLista.Agregar(20);
        miLista.Agregar(30);
        miLista.Agregar(40);

        Console.Write("Lista actual: ");
        miLista.ImprimirLista(); // Salida: 10 20 30 40

        // Calculamos y mostramos la longitud
        int longitud = miLista.CalcularLongitud();
        Console.WriteLine($"La longitud de la lista es: {longitud}"); // Salida: 4

        Console.WriteLine("---");

        // Probamos con una lista vacía
        ListaEnlazada listaVacia = new ListaEnlazada();
        Console.Write("Lista vacía: ");
        listaVacia.ImprimirLista();
        int longitudVacia = listaVacia.CalcularLongitud();
        Console.WriteLine($"La longitud de la lista vacía es: {longitudVacia}"); // Salida: 0

        Console.WriteLine("---");

        // Probamos con una lista de un solo elemento
        ListaEnlazada listaUnElemento = new ListaEnlazada();
        listaUnElemento.Agregar(100);
        Console.Write("Lista de un elemento: ");
        listaUnElemento.ImprimirLista();
        int longitudUnElemento = listaUnElemento.CalcularLongitud();
        Console.WriteLine($"La longitud de la lista de un elemento es: {longitudUnElemento}"); // Salida: 1
    }
}