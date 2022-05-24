using Consola;



int opcion = 0;
double num = 0;
int resultado = 0;
int volver = 1;


Calculadora calc = new Calculadora(0);

do
{
    Console.WriteLine("ingrese un num para empezar a operar: \n");
    Console.WriteLine("1: suma, 2: resta, 3:multiplicacion, 4:division, 5:limpiar\n");
    opcion = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("ingrese un numero\n");
    num = Convert.ToDouble(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            calc.suma(num);
            break;
        case 2:
            calc.resta(num);
            break;
        case 3:
            calc.multiplicacion(num);
            break;
        case 4:
            calc.division(num);
            break;
        case 5:
            calc.limpiar(num);
            break;
    }

    Console.WriteLine("el resultado es \n" + calc.resultado);
    Console.WriteLine("si desea volver a operar presione cero 0\n");
    volver = Convert.ToInt32(Console.ReadLine());

} while (volver == 0);
