namespace exercici14;

// Declara una paraula i fes que el programa imprimeixi només la primera lletra, l'última lletra i la lletra del mig 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dime la palabra que quieras");
        var palabra = Console.ReadLine();

        char uno = palabra[0];
        char ultimo = palabra[palabra.Length-1];
        int posicioMig = palabra.Length / 2;
        char mig = palabra[posicioMig];


        Console.WriteLine("Primera lletra: " + uno);
        Console.WriteLine("Lletra Mig: " + mig);
        Console.WriteLine(" Ultima lletra: " + ultimo);





    }
}


