namespace exercici16;

/* Ningú entén res del nou sistema d’avaluació. Necessitem un programa que calculi la part que és més senzilla: 
a partir de la mitjana de les notes les pràctiques i la nota de l’examen ens calculi la nota final

Nota de pràctiques: 8
Nota de l’examen: 9
La nota final és 8.7 o sigui un 8

Nota de pràctiques: 10
Nota de l’examen: 5
La nota final és 6.5 o sigui un 7 
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nota Examen");
        var examen = Console.ReadLine();
        double examen1 = Convert.ToDouble(examen);

        Console.WriteLine("Nota Practicas");
        var Practicas = Console.ReadLine();
        double Practicas1 = Convert.ToDouble(Practicas);

        double media = (examen1 * 0.7) + (Practicas1 * 0.3);

        Console.WriteLine("La mitjana es: " + media);
    }
}
