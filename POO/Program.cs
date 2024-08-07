class Vehiculo
{
    public string Marca { get; set; }

    public string Modelo { get; set; }

    public Vehiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }
    protected void MostrarInfo()
    {
        Console.WriteLine($"\nMarca: {Marca} \nModelo: {Modelo}");
    }
}

class Vehiculo4R : Vehiculo
{
    public int NumeroPuertas { get; set; }
    
    public Vehiculo4R(string marca, string modelo, int numeroPuertas) : base(marca, modelo)
    {
        NumeroPuertas = numeroPuertas;
    }

    protected void MostrarInfo4R()
    {
        MostrarInfo();
        Console.WriteLine($"Numero de puertas: {NumeroPuertas}");
    }
}

class Auto : Vehiculo4R
{
    public string TipoCombustible { get; set; }
    
    public Auto(string marca, string modelo, int numeroPuertas, string tipoCombustible) : base(marca, modelo, numeroPuertas)
    {
        TipoCombustible = tipoCombustible;
    }
    public void MostrarInfoAuto()
    {
        MostrarInfo4R();
        Console.WriteLine($"Tipo de combustible: {TipoCombustible}");
    }
}


class Program
{
    static void Main()
    {
        Console.Write("Ingrese la marca: ");
        string Marca = Console.ReadLine();

        Console.Write("Ingrese el modelo: ");
        string Modelo = Console.ReadLine();

        Console.Write("Ingrese la cantidad de puertas: ");
        int NumeroPuertas;
        int.TryParse(Console.ReadLine(), out NumeroPuertas);

        Console.Write("Ingrese tipo de combustible: ");
        string TipoCombustible = Console.ReadLine();



        Auto auto = new Auto(Marca, Modelo, NumeroPuertas, TipoCombustible);

        auto.MostrarInfoAuto(); 
    }
}



