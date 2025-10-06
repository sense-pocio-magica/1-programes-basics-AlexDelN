namespace exercici19;

// Assigna una paraula a una variable de text. Utilitza una funció per a obtenir la seva longitud i 
// imprimeix la paraula i el seu nombre de caràcters.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dime una palabra:");
        var palabra = Console.ReadLine();
        int contar = palabra.Length;

        Console.WriteLine("El numero de letras es: " + contar);
        
    }
}
