namespace Ejercicio2;

public enum Cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}

public class Empleado
{

    private string _nombre;
    private string _apellido;
    private DateTime _fechaNacimiento;
    private char _estadoCivil;
    private char _genero;
    private DateTime _fechaIngreso;
    private double _sueldo;
    private Cargos _cargo;

    public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, char genero, DateTime fechaIngreso, double sueldo, Cargos cargo)
    {
        _nombre = nombre;
        _apellido = apellido;
        _fechaNacimiento = fechaNacimiento;
        _estadoCivil = estadoCivil;
        _genero = genero;
        _fechaIngreso = fechaIngreso;
        _sueldo = sueldo;
        _cargo = cargo;
    }

    public int Antiguedad()
    {
        DateTime fechaActual = DateTime.Now;
        int ano = fechaActual.Year - _fechaIngreso.Year;

        if (fechaActual.Month >= _fechaIngreso.Month && fechaActual.Day >= _fechaIngreso.Day)
        {
            return ano;
        }

        return ano - 1;
    }

    public int Edad()
    {
        DateTime fechaActual = DateTime.Now;
        int edad = fechaActual.Year - _fechaNacimiento.Year;

        if (fechaActual < _fechaNacimiento.AddYears(edad))
        {
            edad--;
        }

        return edad;
    }

    public int AnosJubilacion()
    {
        int anos = 0;

        if (_genero == 'M')
        {
            anos = 65 - Edad();
        }
        else if (_genero == 'H')
        {
            anos = 60 - Edad();
        }

        return anos > 0 ? anos : 0;
    }

    public double Salario()
    {
        double adicional = 0;

        if (Antiguedad() <= 20)
        {
            adicional += Antiguedad() * 0.1f * _sueldo;
        }
        else if (Antiguedad() > 20)
        {
            adicional += _sueldo * 0.25f;
        }

        if (_cargo == Cargos.Ingeniero || _cargo == Cargos.Especialista)
        {
            adicional += _sueldo * 0.50f;
        }

        if (_estadoCivil == 'S')
        {
            adicional += 15000;
        }

        return _sueldo + adicional;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Nombre: " + _nombre);
        Console.WriteLine("Apellido: " + _apellido);
        Console.WriteLine("Fecha de nacimiento: " + _fechaNacimiento);
        Console.WriteLine("Estado Civil: " + _estadoCivil);
        Console.WriteLine("Genero: " + _genero);
        Console.WriteLine("Fecha Ingreso: " + _fechaIngreso);
        Console.WriteLine("Sueldo: " + Salario());
        Console.WriteLine("Cargo: " + _cargo.ToString());
    }
}