int a1, a2, b1, b2;
Console.WriteLine(" Ingrese el valor para A1: ");
a1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el valor para A2: ");
a2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el valor para B1: ");
b1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el valor para B2: ");
b2 = int.Parse(Console.ReadLine());

var distancia = Math.Sqrt((Math.Pow(a1 - a2, 2) + Math.Pow(b1 - b2, 2)));
Console.WriteLine("La distancia es: " + distancia);