namespace Ejercicio2;

static class Program
{

    public static int Main(string[] args)
    {

        Empleado empleado1 = new Empleado("Pedro", "Jose", new DateTime(1975, 4, 3),
            'S', 'H', new DateTime(1999, 2, 2), 15000, Cargos.Administrativo);

        Empleado empleado2 = new Empleado("Ana", "María", new DateTime(1989, 4, 25),
            'C', 'M', new DateTime(2002, 2, 2), 14000, Cargos.Ingeniero);

        Empleado empleado3 = new Empleado("Juan", "Perez", new DateTime(2000, 7, 20),
            'S', 'H', new DateTime(2015, 5, 5), 17000, Cargos.Auxiliar);

        Double totalSalarios = empleado1.Salario() + empleado2.Salario() + empleado3.Salario();
        Console.WriteLine("Total de salarios: " + Math.Round(totalSalarios,3) + '\n');

        Console.WriteLine("Empleado más cerca de la jubliación:");
        if (empleado1.AnosJubilacion() <= empleado2.AnosJubilacion() && empleado1.AnosJubilacion() <= empleado3.AnosJubilacion())
        {
            empleado1.MostrarInformacion();
        }
        else if (empleado2.AnosJubilacion() <= empleado1.AnosJubilacion() && empleado2.AnosJubilacion() <= empleado3.AnosJubilacion())
        {
            empleado2.MostrarInformacion();
        }
        else if (empleado3.AnosJubilacion() <= empleado1.AnosJubilacion() && empleado3.AnosJubilacion() <= empleado2.AnosJubilacion())
        {
            empleado3.MostrarInformacion();
        }

        return 0;
    }
}

