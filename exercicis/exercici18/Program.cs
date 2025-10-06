namespace exercici18;

/* Un rellotger està perdent la memòria i necessita un programa que a partir de l'hora actual li puguem dir
 quina hora serà d’aquí un nombre determinat d’hores.

Hora actual: 9
Hores a incrementar: 3
D'aquí a 3 hores seran les 12


Hora actual: 11
Hores a incrementar: 3
D'aquí a 3 hores seran les 2
*/ 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dime la hora que es: del 0 al 12 ");
        var hora = Console.ReadLine();


        Console.WriteLine("Dime el incremento de las horas");
        int hora1 = Convert.ToInt16(hora);
        var aumento = Console.ReadLine();
        int aumento1 = Convert.ToInt16(aumento);

        int suma = hora1 + aumento1;


        int final = suma % 12;


        Console.WriteLine("La hora actual es: " + final);
    }
}
