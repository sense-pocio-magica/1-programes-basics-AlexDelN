namespace exercici9;

/* Demana un valor en metres. Converteix el valor a peus (1 metre = 3,28084 metres) 
i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dime el valor de metros que quieres que combierta");
        var metros = Console.ReadLine();
        double metros1 = Convert.ToDouble(metros);

        Console.WriteLine("La conversio de metres a peus es: " + (metros1 * 3.28084).ToString("F2"));
    }
}
