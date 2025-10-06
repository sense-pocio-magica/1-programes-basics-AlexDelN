namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dime la primera nota que tienes");
        var not1 = Console.ReadLine();
        double nota1 = Convert.ToDouble(not1);

        Console.WriteLine("Dime la segunda nota que tienes");
        var not2 = Console.ReadLine();
        double nota2 = Convert.ToDouble(not2);

        Console.WriteLine("Dime la tercera nota que tienes");
        var not3 = Console.ReadLine();
        double nota3 = Convert.ToDouble(not3);

        var suma = (nota1 + nota2 + nota3);
        double suma1 = Convert.ToDouble(suma);
        
        Console.WriteLine("La mitjana de les notes es: " + (suma1 / 3));

    }
}
