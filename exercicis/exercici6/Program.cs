using System.Threading.Tasks.Dataflow;

namespace exercici6;

/* Declara una variable per al costat d'un quadrat. Calcula el seu perímetre (suma dels quatre costats) 
i imprimeix-lo. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cuanto mida cada lado del cuadrado?");
        var lado = Console.ReadLine();
        double lado1 = Convert.ToDouble(lado);

        Console.WriteLine(("La suma dels cuatre costats es: ") + lado1 * 4);
    }
}
