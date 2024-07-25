internal class Program
{
    static List<double> Numeros = new List<double>();
    static double Total = 0;
    static int Cantidad = 0;
    static double Resultado = 0;
    //Ciclo para el menú
    static void Main(string[] args)
    {
        while (true)
        {
            MostrarMenú();
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    PedirNumeros();
                    break;
                case 2:
                    Resultado = CalcularMedia(Total, Cantidad);
                    MostrarResultado("La media calculada es: " + Resultado); 
                    break;
                case 3:
                    MostrarResultado();
                    break;
                case 4:
                    MostrarResultado();
                    break;
                case 5:
                    MostrarResultado();
                    break;
                case 6:
                    PedirNumeros();
                    break;
                case 7:
                    MostrarResultado();
                    break;
            }
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
    Console.WriteLine("7.Mostrar resultados");
    Console.Write("Escriba una opción: ");
}
//Método para pedir y guardar numeros
static void PedirNumeros()
{
    Console.Clear();
    Console.Write("Ingrese la cantidad de números que quiere ingresar: ");
    RegistrarNumeros();
}
static void RegistrarNumeros()
{
    double Entrada = 0;
    Cantidad = int.Parse(Console.ReadLine());
    for (int i = 0; i < Cantidad; i++)
    {
        Console.Write($"Ingrese el {i + 1} número: ");
            Numeros.Add(double.Parse(Console.ReadLine()));
            Total += Numeros[i];
    }
    Console.Clear();
    Console.WriteLine("Números registrados...");
    Console.WriteLine("\nPresione una tecla para continuar: ");
    Console.ReadKey();
}
    static double CalcularMedia(double a, double b)
    {
        return a / b;    
    }
    static void MostrarResultado()
    {
        Console.Clear();
        Console.WriteLine("Números ingresados: ");
        foreach (double numero in Numeros)
        {
            Console.WriteLine(numero);
        }
        Console.WriteLine("Ultimo resultado: "+ Resultado);
        Console.ReadKey();
    }
    static void MostrarResultado(string mensaje)
    {
        Console.Clear();
        Console.WriteLine(mensaje);
        Console.ReadKey();
    }

}