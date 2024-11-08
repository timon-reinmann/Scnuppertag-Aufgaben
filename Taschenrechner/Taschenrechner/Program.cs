using System;

class Program
{
    static void Main()
    {
        bool weiter = true;

        while (weiter)
        {
            Console.WriteLine("Gib die erste Zahl ein:");
            double zahl1;
            while (!double.TryParse(Console.ReadLine(), out zahl1))
            {
                Console.WriteLine("Ungültige Eingabe. Bitte eine Zahl eingeben:");
            }

            Console.WriteLine("Gib die zweite Zahl ein:");
            double zahl2;
            while (!double.TryParse(Console.ReadLine(), out zahl2))
            {
                Console.WriteLine("Ungültige Eingabe. Bitte eine Zahl eingeben:");
            }

            Console.WriteLine("Gib den Operator ein (+, -, *, /, %, ^):");
            string op = Console.ReadLine();

            double ergebnis = 0;
            bool gueltigerOperator = true;

            switch (op)
            {
                case "+":
                    ergebnis = zahl1 + zahl2;
                    break;
                case "-":
                    ergebnis = zahl1 - zahl2;
                    break;
                case "*":
                    ergebnis = zahl1 * zahl2;
                    break;
                case "/":
                    if (zahl2 == 0)
                    {
                        Console.WriteLine("Fehler: Division durch Null ist nicht erlaubt.");
                        gueltigerOperator = false;
                    }
                    else
                    {
                        ergebnis = zahl1 / zahl2;
                    }
                    break;
                case "%":
                    ergebnis = zahl1 % zahl2;
                    break;
                case "^":
                    ergebnis = Math.Pow(zahl1, zahl2);
                    break;
                default:
                    Console.WriteLine("Ungültiger Operator.");
                    gueltigerOperator = false;
                    break;
            }

            if (gueltigerOperator)
            {
                Console.WriteLine($"Ergebnis: {ergebnis}");
            }

            Console.WriteLine("Möchtest du eine weitere Berechnung durchführen? (j/n)");
            string weiterEingabe = Console.ReadLine().ToLower();
            weiter = weiterEingabe == "j";
        }

        Console.WriteLine("Programm beendet.");
    }
}
