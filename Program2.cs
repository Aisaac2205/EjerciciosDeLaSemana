double an = 0;
double al = 0;

Console.WriteLine("Ingrese el ancho del rectangulo: ");
an = int.Parse(Console.ReadLine());  
Console.WriteLine("Ingrese la altura del rectangulo: ");
al = int.Parse(Console.ReadLine());
double perimetro = 2 * (an + al);
Console.WriteLine("El perímetro del rectángulo es: " + perimetro);
Console.ReadKey();