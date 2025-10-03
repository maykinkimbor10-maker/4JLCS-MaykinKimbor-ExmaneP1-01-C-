using System;

abstract class Animal
{
    public abstract string Descripcion();
    public abstract string Clasificacion(int x, int y);
}

class Mamifero : Animal
{
    public override string Descripcion()
    {
        return "Mamifero: de sangre caliente y con pelo.";
    }

    public override string Clasificacion(int x, int y)
    {
        return $"Suma: {x} + {y} = {x + y}";
    }
}

class Reptil : Animal
{
    public override string Descripcion()
    {
        return "Reptil: de sangre fria y con escamas.";
    }

    public override string Clasificacion(int x, int y)
    {
        return $"Resta: {x} - {y} = {x - y}";
    }
}

class Anfibio : Animal
{
    public override string Descripcion()
    {
        return "Anfibio: puede vivir en agua y en tierra.";
    }

    public override string Clasificacion(int x, int y)
    {
        int resultado = 1;
        for (int i = 0; i < y; i++)
        {
            resultado *= x;
        }
        return $"Potencia: {x} ^ {y} = {resultado}";
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione alguno de los 3 animales:");
        Console.WriteLine("1. Mamifero");
        Console.WriteLine("2. Reptil");
        Console.WriteLine("3. Anfibio");
        Console.Write("Ingrese opcion: ");
        string opcion = Console.ReadLine();

        int x, y;
        try
        {
            Console.Write("Ingrese un primer numero: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un segundo numero: ");
            y = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Error: ingresar solo numeros enteros.");
            return;
        }

        Animal animal;

        switch (opcion)
        {
            case "1":
                animal = new Mamifero();
                break;
            case "2":
                animal = new Reptil();
                break;
            case "3":
                animal = new Anfibio();
                break;
            default:
                Console.WriteLine("Opcion no valida");
                return;
        }

        Console.WriteLine("\n--- RESULTADO ---");
        Console.WriteLine("Descripcion: " + animal.Descripcion());
        Console.WriteLine("Clasificacion: " + animal.Clasificacion(x, y));
    }
}