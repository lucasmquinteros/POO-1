class Estudiante
{
    private string _nombre;
    private int _legajo;
    private double _promedio;

    public Estudiante(string nombre, int legajo, Double promedio)
    {
        _nombre = nombre;
        _legajo = legajo;
        _promedio = promedio;
    }

    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }
    public int Legajo
    {
        get { return _legajo; }
        set { _legajo = value; }
    }
    public double Promedio
    {
        get { return _promedio; }
        private set { _promedio = value; }
    }
    

    public void ActualizarPromedio(double promedio)
    {
        if(promedio < 0 || promedio > 10)
        {
            Console.WriteLine("Ingrese un promedio valido, un valor entre 0 a 10");
        }
        else
        {
            Promedio = promedio;
            Console.WriteLine($"Promedio actualizado: {Promedio}");
        }
    }
}


class Program
{
    static void Main()
    {
        Estudiante alumno = new Estudiante("Santuvu", 91, 7);
        Console.WriteLine($"El promedio de {alumno.Nombre} es: {alumno.Promedio}");
        alumno.ActualizarPromedio(8.70);
    }
}