namespace exercici12;

/* Fes un programa que a partir de dos números imprimeixi per pantalla la seva suma, la seva resta, 
la seva multiplicació i la seva divisió

Entra el primer número: 3
Entra el segon número: 4

4 + 3 = 7
4 - 3 = 1
4 * 5 = 12
4 / 3 = 1  i en sobra 1


Entra el primer número: 25
Entra el segon número: 5

25 + 5 = 30
25 - 5 = 20
25 * 5 = 125
25 / 5 = 5  i en sobra 0
*/



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dime el primer numero");
        var num1 = Console.ReadLine();
        int num_1 = Convert.ToInt16(num1);

        Console.WriteLine("Dime el segundo numero");
        var num2 = Console.ReadLine();
        int num_2 = Convert.ToInt16(num2);

        int division = num_1 % num_2;
        Console.WriteLine(num1 + " + " + num2 + " = " + (num_1 + num_2));
        Console.WriteLine(num1 + " - " + num2 + " = " + (num_1 - num_2));
        Console.WriteLine(num1 + " * " + num2 + " = " + (num_1 * num_2));
        Console.WriteLine(num1 + " / " + " = " + (num_1 / num_2) + " sobran: " + division); 

    }
}
