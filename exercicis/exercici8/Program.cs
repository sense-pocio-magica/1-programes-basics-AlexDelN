namespace exercici8;

/* Assigna un nombre total de minuts a una variable. 
Calcula quantes hores senceres i minuts restants són i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dime los minutos que quieres calcualar");
        int minutos = Convert.ToInt32(Console.ReadLine());
        int horas = minutos / 60;
        int minRestantes = minutos % 60;
        Console.WriteLine("Horas " + (horas) + " Minutos " + (minRestantes));
    }
}
