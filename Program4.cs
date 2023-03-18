Console.WriteLine("Escriba un número entero positivo para verificar si es par o impar\n");
int n = int.Parse(Console.ReadLine());
if (n % 2 == 0)
{
    Console.WriteLine($"{n} es par");
}

else
{
    Console.WriteLine($"{n} es impar");
}
Console.ReadKey();