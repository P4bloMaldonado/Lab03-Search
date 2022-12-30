namespace Lab03_Search;
class LinealSearchRandom
{
    static void Main(string[] args)
    {
        DateTime inicio = DateTime.Now;
        string comienzoEjecucion = DateTime.Now.ToString("hh:mm:ss tt");
        Console.WriteLine("Comienzo de ejecucion del programa: " + comienzoEjecucion );       
        Random random = new Random();
        int busquedaFallida = 0;
        int busquedaExitosa = 0;
        int[] A;
        A = new int[100];
        for(int i = 0 ; i<100; i++){
            A[i]= random.Next(1,201);
        }
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
        for(int i = 0; i < 50; i++){
            int posicionEncontrada = BusquedaLinealID(A, A.Length, random.Next(1,201));
            if(posicionEncontrada == -1 ){

                busquedaFallida++;
            }else{
                busquedaExitosa++;        }
        }

        Console.WriteLine("\nBusquedas Exitosas: " + busquedaExitosa);
        Console.WriteLine("Busquedas Fallidas: " + busquedaFallida);
        Console.WriteLine("Porcentaje de Exito " + busquedaExitosa*2 +"% ");
        Console.WriteLine("Porcentaje de Fallas " + busquedaFallida*2 +"% ");
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
