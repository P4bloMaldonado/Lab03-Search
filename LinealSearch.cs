namespace Lab03_Search;
class LinealSearch
{
    static void Main1(string[] args)
    {
        DateTime inicio = DateTime.Now;
        string comienzoEjecucion = DateTime.Now.ToString("hh:mm:ss tt");
        Console.WriteLine("Comienzo de ejecucion del programa: " + comienzoEjecucion );
        Console.WriteLine("Algoritmo de busqueda Lineal");

        int[] A = { 79, 21, 15, 99, 88, 65, 75, 85, 76, 46, 84, 24, 12, 13, 25, 7, 99, 82, 19, 29 };

        Console.WriteLine("Arreglo Desordenado");

        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($" A[{i}]= {A[i]}, ");
        }
        Array.Sort(A);

        Console.WriteLine("\nArreglo Ordenado");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($" A[{i}]= {A[i]}, ");
        }
        Console.Write("\nIngrese el elemento a encontrar: ");
        int valorBusqueda = int.Parse(Console.ReadLine());
        int posicionEncontrada = BusquedaLinealID(A, A.Length, valorBusqueda);
        if(posicionEncontrada == -1 ){

            Console.WriteLine("\nValor no encontrado");
        }else{
            Console.Write($"\nElemento Encontrado en A[{posicionEncontrada}]= {A[posicionEncontrada]} " );
        }
        double tiempoEjecucion = DateTime.Now.Subtract(inicio).Milliseconds;
        Console.WriteLine("Tiempo de ejecucion: " + tiempoEjecucion + "ms") ;
        Console.WriteLine("Final de ejecucion del programa: " + DateTime.Now.ToString("hh:mm:ss tt"));
    }

    static int BusquedaLinealID(int[] A, int n, int clave)
    {
       int i;
    for (i = 0; i < n; i++)
        if (A[i] == clave)
            return i;
    return -1;
    }
}
