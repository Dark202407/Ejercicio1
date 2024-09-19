using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        double sbruto, co, tganado, sventa;
        int ventas, años;
        string nombre;
        Console.WriteLine("Ingrese su sueldo bruto");
        sbruto=double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese su comision");
        co=double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese su cantidad de ventas");
        ventas=int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de años en este trabajo");
        años=int.Parse(Console.ReadLine());
        if (ventas>600)
        {
            sventa = sbruto * 0.05;
        }
        else if (ventas>600 & ventas<=3000)
        {
            sventa = sbruto * 0.07;
        }
        else if (ventas>3000)
        {
            sventa = sbruto + 300 * 0.06;
        }
        tganado = ventas + co;

        if (años>=3)
        {
            tganado = tganado - 6.5;
        }
        else if (años>=4)
        {
            tganado = tganado - 4.5;
        }
        

        Console.WriteLine("Hello, World!");
    }
}