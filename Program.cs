while(true)
{
    MostrarMenú();
    int opcion = int.Parse(Console.ReadLine());
    switch(opcion)
    {
        case 1:
            PedirNumeros();
            break;
        case 2:
            break;
    }
}
//Método para mostrar menú
static void MostrarMenú()
{
    //Opciones del menú
    Console.Clear();
    Console.WriteLine("_____CALCULADORA ESTADISTICA_____");
    Console.WriteLine("1.Ingresar números.");
    Console.WriteLine("2.Calcular la media.");
    Console.WriteLine("3.Calcular la mediana.");
    Console.WriteLine("4.Calcular la moda.");
    Console.WriteLine("5.Calcular la desviación estándar.");
    Console.WriteLine("6.Cambiar de números.");
    Console.Write("Escriba una opción: ");
}
//Método para pedir y guardar numeros
static void PedirNumeros()
{
    Console.Clear();
    Console.Write("Ingrese la cantidad de números que quiere ingresar: ");
    int cantidad = int.Parse(Console.ReadLine());
    for (int i = 0; i < cantidad; i++)
    {
        Console.Write($"Ingrese el {i+1} número: ");
        double Numero = double.Parse(Console.ReadLine());
    }
    Console.Clear();
    Console.WriteLine("Números registrados...");
    Console.WriteLine("\nPresione una tecla para continuar: ");
    Console.ReadKey();
}