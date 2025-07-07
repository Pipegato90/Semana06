public class Nodo
{
    public int Valor { get; set; } // El dato almacenado en el nodo
    public Nodo Siguiente { get; set; } // Referencia al siguiente nodo

    public Nodo(int valor)
    {
        Valor = valor;
        Siguiente = null; // Por defecto, el siguiente nodo es nulo
    }
}