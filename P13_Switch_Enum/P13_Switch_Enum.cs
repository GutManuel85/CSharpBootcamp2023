namespace P13_Switch_Enum
{
    internal class P13_Switch_Enum
    {

        static void Main(string[] args)
        {
            // Programm beenden über schliessen der Konsole.
            while (true)
            {
                int weekday = -1;
                while (weekday < 1 || weekday > 7)
                {
                    Console.WriteLine("Bitte gib einen Wochentag (1-7) ein:");
                    if (!int.TryParse(Console.ReadLine(), out weekday))
                    {
                        Console.WriteLine("Ungültige Eingabe. Nur Werte von 1-7 sind erlaubt.");
                    }
                    else
                    {

                        String weekdayString;

                        switch (weekday)
                        {
                            case 1:
                                weekdayString = "Montag";
                                break;
                            case 2:
                                weekdayString = "Dienstag";
                                break;
                            case 3:
                                weekdayString = "Mittwoch";
                                break;
                            case 4:
                                weekdayString = "Donnerstag";
                                break;
                            case 5:
                                weekdayString = "Freitag";
                                break;
                            case 6:
                                weekdayString = "Samstag";
                                break;
                            case 7:
                                weekdayString = "Sonntag";
                                break;
                            default:
                                weekdayString = "ein Wochentag";
                                break;
                        }

                        /*
                        Modernere Schreibeweise wäre so:

                        string weekdayString = weekday switch
                        {
                            1 => "Montag",
                            2 => "Dienstag",
                            3 => "Mittwoch",
                            4 => "Donnerstag",
                            5 => "Freitag",
                            6 => "Samstag",
                            7 => "Sonntag",
                            _ => "ein Wochentag",
                        };
                         */

                        Console.WriteLine($"Heute ist {weekdayString}");


                        // *************** Weiteres Beispiel mit Enum *********************
                        Console.WriteLine("Welche Auflösung möchtest du (720, 1920, 3840)?");

                        int inputNumber;
                        if (!int.TryParse(Console.ReadLine(), out inputNumber))
                        {
                            Console.WriteLine("Unzulässige Eingabe");
                        }
                        else
                        {
                            Resolutions resolution = (Resolutions)inputNumber;
                            String message = resolution switch
                            {
                                Resolutions.SD => "Standard",
                                Resolutions.HD => "High Definition",
                                Resolutions.UHD => "Ultra High Definition",
                                _ => "Auflösung unbekannt"
                            };
                            Console.WriteLine(message);

                        }
                    }
                }
            }
        }

    }
}
