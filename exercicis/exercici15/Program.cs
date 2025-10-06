namespace exercici15;

// Assigna un nom i un cognom en variables. Imprimeix el nom complet, 
// assegurant-te que la primera lletra de cada paraula estigui en majúscula
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dime tu nombre");
        var nom = Console.ReadLine();

        Console.WriteLine("Dime tu apellido");
        var apellido = Console.ReadLine();

        string nom1 = nom.Substring(0, 1).ToUpper() + nom.Substring(1).ToLower();
        string apellido1 = apellido.Substring(0, 1).ToUpper() + apellido.Substring(1).ToLower();

        Console.WriteLine("Nom formatat " + nom1 + " " + apellido1);



    }
}
