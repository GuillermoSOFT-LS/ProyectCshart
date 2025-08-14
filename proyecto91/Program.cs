using System;

class EmpleadosFaltas
{
    private string[] empleados;
    private int[][] faltas;

    public void CargarDatos()
    {
        empleados = new string[3];
        faltas = new int[3][];

        for (int i = 0; i < empleados.Length; i++)
        {
            Console.Write($"Nombre del empleado {i + 1}: ");
            empleados[i] = Console.ReadLine();

            Console.Write($"Cantidad de días que faltó {empleados[i]}: ");
            int cantidadFaltas = int.Parse(Console.ReadLine());

            faltas[i] = new int[cantidadFaltas];
            for (int j = 0; j < cantidadFaltas; j++)
            {
                Console.Write($"Ingrese día de falta {j + 1}: ");
                faltas[i][j] = int.Parse(Console.ReadLine());
            }
        }
    }


    public void MostrarFaltas()
    {
        Console.WriteLine("\nCantidad de inasistencias por empleado:");
        for (int i = 0; i < empleados.Length; i++)
        {
            Console.WriteLine($"{empleados[i]}: {faltas[i].Length} días");
        }
    }


    public void MostrarEmpleadoMenosFaltas()
    {
        int indiceMenor = 0;
        for (int i = 1; i < empleados.Length; i++)
        {
            if (faltas[i].Length < faltas[indiceMenor].Length)
            {
                indiceMenor = i;
            }
        }
        Console.WriteLine($"\nEmpleado con menos faltas: {empleados[indiceMenor]} con {faltas[indiceMenor].Length} días.");
    }
}

class Program
{
    static void Main()
    {
        EmpleadosFaltas empresa = new EmpleadosFaltas();

        empresa.CargarDatos();
        empresa.MostrarFaltas();
        empresa.MostrarEmpleadoMenosFaltas();
        Console.ReadKey();
    }
}
