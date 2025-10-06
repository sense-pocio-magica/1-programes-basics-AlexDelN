namespace exercici5;

/* Feu un programa que demani un nom i l’any de naixement i imprimeixi per pantalla 
“Hola [nom]!  Ja tens [edat] anys? 
nom i edat seran el nom introduït i l'edat la resta de l’any actual i l’any de naixement. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Buenas, qual es tu nombre?");
        var nom = Console.ReadLine();

        Console.WriteLine("Y tu año de nacimiento?");
        var edad = Console.ReadLine();
        int edad1 = Convert.ToInt16(edad);

        Console.WriteLine(("Hola ") + (nom) + "!  Ja tens " + (2025 - edad1) + " Anys?" );
    }
}
