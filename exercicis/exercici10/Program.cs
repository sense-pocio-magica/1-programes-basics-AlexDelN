namespace exercici10;

/* Declara dues variables: una per al nom i una altra per l’any de naixement. 
Combina-les per crear una contrasenya bàsica (per exemple, Pere i 1982 -> Pere1982). 
Imprimeix la contrasenya generada (i sobretot no la facis servir mai que és molt dolenta) */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("GENERADOR DE CONTRASENYAS!");
        Console.WriteLine("Quin es el teu nom?");
        var nom = Console.ReadLine();

        Console.WriteLine("Y quin es el teu any de naixement");
        var any = Console.ReadLine();

        Console.WriteLine("Tu contrasenya de mierda es: " + nom + any);
        
        
            }
}
