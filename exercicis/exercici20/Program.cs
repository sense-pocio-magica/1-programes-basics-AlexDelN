using System.Timers;

namespace exercici20;

/* Ens cal un programa que quan li entrem un número de tres xifres i ens retorni 
el número amb els dígits invertits. 

Ex. 245 -> 542
Entra el número a invertir: 347
El número invertit és: 743
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dime el numero de 3 cifras");
        var numeros = Console.ReadLine();
        char uno = numeros[0];
        char dos = numeros[1];
        char tres = numeros[2];

        Console.WriteLine("El numero invertit es: " + tres + dos + uno);
    }
}
