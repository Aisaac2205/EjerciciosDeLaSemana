static int CalcularSumaN(int n)
{
    int suma = 0;
    for (int i = 1; i <= n; i++)
    {

        suma += i;
    }
    return suma;
}
Console.WriteLine("Digite un número entero");
int n = int.Parse(Console.ReadLine());
int suma = CalcularSumaN(n);
Console.WriteLine("La suma es: " + n + +suma);