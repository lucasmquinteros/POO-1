public abstract class FormasGeometrica
{
    public int Cateto1 { get; set; }
    public int Cateto2 { get; set; }
    
    public abstract int Pitagoras(int Cateto1, int Cateto2);
    
    public FormasGeometrica(int cateto1, int cateto2)
    {
        Cateto1 = cateto1;
        Cateto2 = cateto2;
    }
}

public class Triangulo : FormasGeometrica
{ 
    public Triangulo(int cateto1, int cateto2) : base(cateto1, cateto2) { }

    public int hipotenusa {  get; set; }

    public override int Pitagoras(int cateto1, int cateto2)
    {
        hipotenusa = (cateto1*cateto1) + (cateto2*cateto2);
        return hipotenusa;
    }
}

class Program
{
    static void Main()
    {
        FormasGeometrica triangulo = new Triangulo(10, 5);

        Console.WriteLine($"La hipotenusa de su triangulo es: {triangulo.Pitagoras(10, 5)}");
    }
}