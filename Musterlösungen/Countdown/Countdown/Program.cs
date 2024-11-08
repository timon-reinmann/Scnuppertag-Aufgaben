using System;
using System.Threading;

class Countdown
{
    static void Main()
    {
        // Eingabe der Stunden, Minuten und Sekunden
        int stunden = LeseZeit("Gib die Stunden ein:");
        int minuten = LeseZeit("Gib die Minuten ein:");
        int sekunden = LeseZeit("Gib die Sekunden ein:");

        // Berechne die Gesamtzahl der Sekunden
        int gesamtSekunden = stunden * 3600 + minuten * 60 + sekunden;

        Console.WriteLine($"Countdown startet für {stunden:D2}:{minuten:D2}:{sekunden:D2}...");

        // Countdown anzeigen
        for (int i = gesamtSekunden; i >= 0; i--)
        {
            Console.Clear();
            // Zeit im Format HH:MM:SS anzeigen
            TimeSpan verbleibendeZeit = TimeSpan.FromSeconds(i);
            Console.WriteLine($"Countdown: {verbleibendeZeit:hh\\:mm\\:ss}");
            Thread.Sleep(1000);
        }

        Console.WriteLine("Countdown abgeschlossen!");
        Console.Beep(); // Ton abspielen
    }

    // Methode zum Lesen der Eingabezeit
    static int LeseZeit(string prompt)
    {
        int zeit;
        Console.WriteLine(prompt);

        // Sicherstellen, dass die Eingabe eine gültige Zahl ist
        while (!int.TryParse(Console.ReadLine(), out zeit) || zeit < 0)
        {
            Console.WriteLine("Ungültige Eingabe. Bitte eine positive ganze Zahl eingeben:");
        }

        return zeit;
    }
}
