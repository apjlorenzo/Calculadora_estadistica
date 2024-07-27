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
            try
            {
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        PedirNumeros();
                        break;
                    case 2:
                        if (Total != 0)
                        {
                            Resultado = CalcularMedia(Total, Cantidad);
                            MostrarResultado("La media calculada es: " + Resultado);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("No hay números registrados.");
                        }
                        Console.WriteLine("\nPresione una tecla para continuar: ");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        if (Total != 0)
                        {
                            Resultado = CalcularMediana(Numeros);
                            MostrarResultado("La mediana calculada es: " + Resultado);
                        }
                        else
                        {
                            Console.WriteLine("No hay números registrados.");
                        }
                        Console.WriteLine("\nPresione una tecla para continuar: ");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        if (Total != 0)
                        {
                            Resultado = CalcularModa(Numeros);
                            MostrarResultado("La moda calculada es: " + Resultado);
                        }
                        else
                        {
                            Console.WriteLine("No hay números registrados.");
                        }
                        Console.WriteLine("\nPresione una tecla para continuar: ");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        if (Total != 0)
                        {
                            Resultado = CalcularDesviaciónEstandar(Numeros);
                            MostrarResultado("La desviación estandar calculada es: " + Resultado);
                        }
                        else
                        {
                            Console.WriteLine("No hay números registrados.");
                        }
                        Console.WriteLine("\nPresione una tecla para continuar: ");
                        Console.ReadKey();
                        break;
                    case 6:
                        PedirNumeros();
                        break;
                    case 7:
                        MostrarResultado();
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("No es una opción válida.");
                        Console.ReadKey();
                        break;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error de formato: Debe ingresar solo números.");
                Console.WriteLine("Más información: "+ex.Message);
                Console.ReadKey();
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Error: El número es demasiado grande.");
                Console.WriteLine("Más información: "+ex.Message);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
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
        Numeros.Clear();
        Resultado = 0;
        double Entrada = 0;
        Cantidad = int.Parse(Console.ReadLine());
    for (int i = 0; i < Cantidad; i++)
    {
            Console.Write($"Ingrese el {i + 1} número: ");
            Numeros.Add(double.Parse(Console.ReadLine()));
            Total += Numeros[i];
    }
    //Funcón para ordenar los elementos de la lista
    Numeros.Sort();
    Console.Clear();
    Console.WriteLine("Números registrados...");
    Console.WriteLine("\nPresione una tecla para continuar: ");
    Console.ReadKey();
}
    //Método para calcular la media
    static double CalcularMedia(double a, double b)
    {
        return a / b;    
    }
    //Método para calcular la mediana
    static double CalcularMediana(List<double> Nombres)
    {
        int digito = Numeros.Count;
        if (digito % 2 == 0)
        {
            return (Numeros[digito / 2 - 1] + Numeros[digito / 2]) / 2;
        }
        else
        {
            return Numeros[digito / 2];
        }
    }
    //Método para calcular la moda
    static double CalcularModa(List<double> Numeros)
    {
        int contador = 1;
        int maxContador = 1;
        double moda = Numeros[0];

        for (int i = 1; i < Numeros.Count; i++)
        {
            if (Numeros[i] == Numeros[i - 1])
            {
                contador++;
            }
            else
            {
                if (contador > maxContador)
                {
                    maxContador = contador;
                    moda = Numeros[i - 1];
                }
                contador = 1;
            }
        }
        // Comprobar si el último elemento es la moda
        if (contador > maxContador)
        {
            moda = Numeros[Numeros.Count - 1];
        }

        return moda;
    }
    //Método para calcular moda
    static double CalcularDesviaciónEstandar(List<double> Numeros)
    {
        double media = Numeros.Average();
        double sumatoriaCuadrados = 0;

        foreach (double numero in Numeros)
        {
            double diferencia = numero - media;
            sumatoriaCuadrados += diferencia * diferencia;
        }

        double varianza = sumatoriaCuadrados / (Numeros.Count - 1);
        double desviacionEstandar = Math.Sqrt(varianza);

        return desviacionEstandar;
    }

    //Métodos para mostrar resultados
    static void MostrarResultado()
    {
        if (Numeros!=null)
        {
            Console.Clear();
            Console.WriteLine("Números ingresados: ");
            foreach (double numero in Numeros)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("Ultimo resultado: " + Resultado);
        }
        else
        {
            Console.WriteLine("No hay numeros resgistrados.");
        }
        Console.WriteLine("\nPresione una tecla para continuar: ");
    }
    static void MostrarResultado(string mensaje)
    {
        Console.Clear();
        Console.WriteLine(mensaje);
    }
}