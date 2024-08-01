public abstract class Empleado
{
    public string Nombre { get; set; }
    public int Salario { get; set; }

    public abstract int CalcularSalario();
    public Empleado(string nombre, int salario)
    {
        Nombre = nombre;
        Salario = salario;
    }
}

public class EmpleadoTiempoCompleto: Empleado 
{ 
    public EmpleadoTiempoCompleto(string nombre, int salario) : base (nombre, salario) { }
    public override int CalcularSalario()
    {
        return Salario;
    }
}

public class EmpleadoMedioTiempo : Empleado
{
    public EmpleadoMedioTiempo(string nombre, int salario) : base(nombre, salario) { }

    public override int CalcularSalario()
    {
        return Salario/2;
    }
}

class Program
{
    static void Main()
    {
        var empleadoTiempoCompleto = new EmpleadoTiempoCompleto("Pepito", 200);
        Console.WriteLine($"El empleado {empleadoTiempoCompleto.Nombre} cobra: {empleadoTiempoCompleto.CalcularSalario()}");
        var empleadoMedioTiempo = new EmpleadoMedioTiempo("Lukitas", 5000);
        Console.WriteLine($"El empleado {empleadoTiempoCompleto.Nombre} cobra: {empleadoMedioTiempo.CalcularSalario()}");

    }
}
