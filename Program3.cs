Console.WriteLine("Digite una lista de números separados para calcular");

string input = Console.ReadLine();
var numero = input.Split(' ').Select(int.Parse);
double a = numero.Average();

Console.WriteLine($"El promedio de los numeros que ingreso es: {a}");
Console.ReadKey();
