Console.WriteLine("Ingrese un número para saber su factorial: ");
int num = Convert.ToInt32(Console.ReadLine());
int factorial = 1;
for (int i = 1; i <= num; i++)
{
    factorial = factorial * i;
}
Console.WriteLine("El factorial de " + num + " es " + factorial);
Console.ReadLine();

