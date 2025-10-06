namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {
        string Nom_Producte = "Cactus";
        int Preu = 10;
        bool Stock = false;



        Console.WriteLine("El producte " + (Nom_Producte) + " con el precio " + (Preu));
        if (Stock == true)
        {

            Console.WriteLine("Te Stock? Si");

        }
        else
        {

            Console.WriteLine("Te stock? Buscalo en tu casa, Pol Casiñol"); 
        }
    }
}
