using System.ComponentModel;

namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hola, fare unes preguntes per agafar la teva direcció");
        Console.WriteLine("Carrer");
        var carrer = Console.ReadLine();

        Console.WriteLine("Numero");
        var Numero = Console.ReadLine();
        int num = Convert.ToInt16(Numero);

        Console.WriteLine("Codi Postal");
        var CodiP = Console.ReadLine();
        int Postal = Convert.ToInt16(CodiP);

        Console.WriteLine("Poblacio");
        var Poblacio = Console.ReadLine();

        Console.WriteLine("La teva direcció es : Carrer " + (carrer) + " Numero " + (num) + " Codi Postal " + (Postal) + " Poblacio " + (Poblacio));

    }
}
