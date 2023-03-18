double area = 0, r = 3.5; ;
Console.WriteLine("Bienvenido, siga las instrucciones para saber el área de un circulo\n");
Console.WriteLine("Ingrese el área de un circulo\n");

r = int.Parse(Console.ReadLine());
area = r * r * 3.1415;

Console.WriteLine("El área del circulo es: " +area);

Console.ReadKey();