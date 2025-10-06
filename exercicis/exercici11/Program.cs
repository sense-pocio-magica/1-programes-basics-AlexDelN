namespace exercici11;

// A partir de dues variables (nom d'usuari i domini), crea i imprimeix una adreça de correu electrònic completa.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quin es el teu nom d'usuari");
        var nom = Console.ReadLine();

        Console.WriteLine("Quin es el domini que vols utilitzar?");
        var domini = Console.ReadLine();


        Console.WriteLine("La teva adreça de correu electronic es:");
        Console.WriteLine(nom + ("@") + domini);
    }
}
