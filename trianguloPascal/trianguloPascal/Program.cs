

try
{
    Console.WriteLine("Ingrese un número, entre 2 y 10 :");
    int numero = int.Parse(Console.ReadLine());

    if (numero < 2 || numero > 10)
    {
        Console.Clear();
        Console.WriteLine("Por favor, ingrese un número válido, entre 2 y 10.");
        return;
    }

    ImprimirTrianguloPascal(numero);
}
catch
{
    Console.Clear();
    Console.WriteLine("Debe ingresar un valor númerico");
}

static void ImprimirTrianguloPascal(int numero)
{
    Console.Clear();
    for (int i = 0; i < numero; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write(CalcularCoeficienteBinomial(i, j) + " ");
        }
        Console.WriteLine();
    }
}

static int CalcularCoeficienteBinomial(int n, int r)
{
    return Factorial(n) / (Factorial(r) * Factorial(n - r));
}

static int Factorial(int num)
{
    if (num == 0 || num == 1)
        return 1;
    else
        return num * Factorial(num - 1);
}