float n1, n2;

Console.Write("Ingrese un número: ");
float.TryParse(Console.ReadLine(), out n1);


Console.Write("Ingrese un número: ");
float.TryParse(Console.ReadLine(), out n2);


Console.WriteLine($"Suma: {n1 + n2}");

Console.WriteLine($"Resta: {n1 - n2}");

Console.WriteLine($"Multiplicación: {n1 * n2}");

while(n2 == 0)
{
    Console.Write("Ingrese un valor distinto a 0\nAqui: ");
    float.TryParse(Console.ReadLine(), out n2);
}
float Resultado = n1 / n2;

Console.WriteLine($"Division: {Resultado}");

