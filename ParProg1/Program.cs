string[] convertValues = { "Valuta", "Temperatur", "Vekt"};
double NokVerdi = 10.34;
double UsdVerdi = 1.00;
int GraderC = 20;
int GraderF = 68;
int Kg = 70;
int lbs = 154;

Console.WriteLine("Hva vil du konvertere? (Valuta/Temperatur/Vekt)");
string valgt = Console.ReadLine();

if (valgt == "Valuta")
{
    Console.WriteLine("Skriv 'NOK' For å konvertere NOK - USD eller 'USD' for å konvertere USD - NOK");
    string valutaType = Console.ReadLine();
    if (valutaType == "NOK")
    {
        Console.WriteLine(NokVerdi + "NOK = " + (NokVerdi / 10.34) + "USD");
    }
    else
    {
        Console.WriteLine(UsdVerdi + "USD = " + (UsdVerdi * 10.34) + "NOK");
    }
}
else if (valgt == "Temperatur")
{
    Console.WriteLine("Skriv 'C' for å konvertere Celsius til Fahrenheit eller 'F' for å konvertere Fahrenheit til Celsius");
    string tempType = Console.ReadLine();
    if (tempType == "C")
    {
        Console.WriteLine(GraderC + "°C = " + (GraderC * 9.0 / 5.0 + 32) + "°F");
    }
    else
    {
        Console.WriteLine(GraderF + "°F = " + ((GraderF - 32) * 5.0 / 9.0) + "°C");
    }
}
else if (valgt == "Vekt")
{
    Console.WriteLine("Skriv 'KG' for å konvertere KG til LBS eller 'LBS' for å konvertere LBS til KG");
    string vektType = Console.ReadLine();
    if (vektType == "KG")
    {
        Console.WriteLine(Kg + "kg = " + (Kg * 2.20) + " lbs");
    }
    else
    {
        Console.WriteLine(lbs + "lbs = " + (lbs / 2.20) + " kg");
    }
}