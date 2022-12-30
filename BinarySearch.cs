namespace Lab03_Search;
class BinarySearch
{
    static void Main2(string[] args)
    {
        DateTime inicio = DateTime.Now;
        string comienzoEjecucion = DateTime.Now.ToString("hh:mm:ss tt");
        Console.WriteLine("Comienzo de ejecucion del programa: " + comienzoEjecucion);
        Console.WriteLine("Algoritmo de busqueda Binaria");
        int[] A = { -8, 4, 5, 9, 12, 18, 25, 40, 60, 60, 11, 18, 29, 39, 31, 47, 99, 12, 68, 48 };

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
        int valorBusqueda = Convert.ToInt32(Console.ReadLine());
        var posicionEncontrada = busquedaBinaria(A, A.Length, valorBusqueda);
        if (posicionEncontrada == -1)
        {

            Console.WriteLine("\nValor no encontrado");
        }
        else
        {
            Console.WriteLine($"\nElemento Encontrado en A[{posicionEncontrada}]= {A[posicionEncontrada]} ");
        }
        Console.WriteLine("Algoritmo de busqueda Binaria 2");
        Console.Write("\nIngrese el elemento a encontrar: ");
        int valorBusqueda2 = Convert.ToInt32(Console.ReadLine());
        var posicionEncontrada2 = BusquedaBinaria(A, A.Length, valorBusqueda2);
        if (posicionEncontrada2 == -1)
        {

            Console.WriteLine("\nValor no encontrado");
        }
        else
        {
            Console.WriteLine($"\nElemento Encontrado en A[{posicionEncontrada2}]= {A[posicionEncontrada2]} ");
        }
        double tiempoEjecucion = DateTime.Now.Subtract(inicio).Milliseconds;
        Console.WriteLine("Tiempo de ejecucion: " + tiempoEjecucion + "ms");
        Console.WriteLine("Final de ejecucion del programa: " + DateTime.Now.ToString("hh:mm:ss tt"));
    }

    static int busquedaBinaria(int[] lista, int n, int clave)
    {
        int central, bajo = 0, alto = n - 1;
        int valorCentral;
        while (bajo <= alto)
        {
            central = (bajo + alto) / 2;
            /* indice de elemento central */
            valorCentral = lista[central];
            /* valor del indice central */
            if (lista[central] == clave)
                return central; /* encontrado, devuelve posicion */
            else if (clave < lista[central])
                alto = central - 1; /* ir a sublista inferior */
            else
                bajo = central + 1; /* ir a sublista superior */
        }
        return -1;
        /* elemento no encontrado */
    }

    static int BusquedaBinaria(int[] lista, int n, int clave)
    {
        int bajo = 0, alto = n - 1, central = -1;
        bool encontrado = false;
        while ((bajo <= alto) && (!encontrado))
        {
            central = (bajo + alto) / 2;
            if (lista[central] == clave)
                encontrado = true;             // éxito en la búsqueda
            else if (clave < lista[central]) // a lo bajo del central
                alto = central - 1;
            else                            // a la alto del central
                bajo = central + 1;
        }
        return encontrado ? central : -1; // central si encontrado -1 otro caso
    }



}
