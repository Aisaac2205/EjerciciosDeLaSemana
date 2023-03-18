Console.WriteLine("Ingrese una cadena de texto que desea convertir:");

string c = Console.ReadLine();
string cadenaMayuscula = ConvertirMayusculas(c);

Console.WriteLine("Su cadena en mayusculas es : " + cadenaMayuscula);
string ConvertirMayusculas(string texto)
{
    return texto.ToUpper();
}
Console.ReadKey();