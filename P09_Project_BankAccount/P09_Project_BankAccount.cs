namespace P09_Project_BankAccount
{
    internal class P09_Project_BankAccount
    {

        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount("1234", "Manuel Gut", 500.0f, "1234");
            string command = "";
            int pinTryCounter = 1;
            string pinInput = "";

            while (true)
            {
                while (pinInput != bankAccount.Pin)
                {
                    if (pinTryCounter < 4)
                    {
                        Console.WriteLine($"Bitte PIN eingeben. Verbleibende Versuche {4 - pinTryCounter} :");
                        pinInput = Console.ReadLine();
                    }
                    else
                    {
                        command = "4";
                        Console.WriteLine("PIN zu oft falsch eingegeben. Karte wird eingezogen.");
                        break;
                    }
                    pinTryCounter++;
                }

                if (command == "4")
                {
                    Console.WriteLine("Besten Dank und auf Wiedersehen.");
                    break;

                }

                Console.WriteLine("Bitte Aktion auswählen");
                Console.WriteLine("1. Kontostand anzeigen");
                Console.WriteLine("2. Geld einzahlen");
                Console.WriteLine("3. Geld abheben");
                Console.WriteLine("4. Beenden");
                command = Console.ReadLine();
                if (command == "1")
                {
                    bankAccount.PrintBalance();
                }
                else if (command == "2")
                {
                    Console.WriteLine("Bitte den einzubezahlenden Betrag eingeben:");
                    float amount = float.Parse(Console.ReadLine());
                    bankAccount.MakeDeposite(amount);
                }
                else if (command == "3")
                {
                    Console.WriteLine("Bitte den Auszahlungsbetrag eingeben:");
                    float amount = float.Parse(Console.ReadLine());
                    bankAccount.MakeWithdraw(amount);

                }
            }
        }
    }
}
