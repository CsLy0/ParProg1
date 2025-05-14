using System;
using System.Net.WebSockets;
class Program
{
    static void Main(string[] args)
    {
        bool fortsett = true;
        while (true)
        {
            //Console.Clear();
            Console.WriteLine("\nHva vil du konvertere? Skriv nummer");
            Console.WriteLine("1. Temperatur");
            Console.WriteLine("2. Valuta");
            Console.WriteLine("3. Vekt");
            Console.WriteLine(" ");

            string valg = Console.ReadLine();

            double verdi, resultat;

            switch (valg)

            {
                case "1":
                    Console.WriteLine("Skriv inn temperaturen i Celsius:");
                    verdi = Convert.ToDouble(Console.ReadLine());
                    resultat = (verdi * 9 / 5) + 32;
                    Console.WriteLine($"{verdi} grader Celsius er {resultat} grader Fahrenheit.");
                    break;


                case "2":
                    Console.WriteLine("Skriv inn beløpet i NOK:");
                    verdi = Convert.ToDouble(Console.ReadLine());
                    resultat = verdi * 0.093;
                    Console.WriteLine($"{verdi} NOK er {resultat} Dollah.");
                    break;
                case "3":
                    Console.WriteLine("Skriv inn vekten i kg:");
                    verdi = Convert.ToDouble(Console.ReadLine());
                    resultat = verdi * 2.205;
                    Console.WriteLine($"{verdi} kg er {resultat} lbs.");
                    break;
            }
        }
    }
}