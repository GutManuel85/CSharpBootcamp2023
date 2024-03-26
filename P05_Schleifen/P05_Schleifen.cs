namespace P05_Schleifen
{
    internal class P05_Schleifen
    {

        public static void Main(string[] args)
        {

            int[] numbers = [50, 200, 75];
            string[] names = ["Manuel", "Robertina", "Joana"];


            // **************** Foreach ****************

            int result = 0;

            foreach (int number in numbers)
            {
                result += number;
            }
            Console.WriteLine(result);


            foreach (string name in names)
            {
                Console.WriteLine(name);
            }



            // **************** For ****************

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // Rückwärts iterieren
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }

            // Zähle von 1 bis 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // Alle gerade Zahlen von 1 bis 30
            int maxNumber = 30;
            for (int i = 2; i <= maxNumber; i += 2)
            {
                Console.WriteLine(i);
            }

            // Zähle rückwärts von 10 bis 1
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }


            // **************** While ****************

            // Zähle von 1 bis 10 hoch
            int counter = 1;
            while (counter <= 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            // Iteriere durch ein Array
            int index = 0;
            while (index < numbers.Length)
            {
                Console.WriteLine(numbers[index]);
                index++;
            }

            // Ratespiel
            int secretNumber = new Random().Next(0, 10);
            string message = "Bitte deine Vermutung eingeben";
            Console.WriteLine(message);
            int guessedNumber = int.Parse(Console.ReadLine());
            while (guessedNumber != secretNumber)
            {
                Console.WriteLine(message);
                guessedNumber = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Das war richtig");




            // **************** Do While ****************

            // Ratespiel einfacher

            int randomNumber = new Random().Next(0, 10);
            int userGuess;
            do
            {
                Console.WriteLine("Bitte deine Vermutung eingeben");
                userGuess = int.Parse(Console.ReadLine());
            } while (userGuess != randomNumber);
            Console.WriteLine("Das war richtig");
        }
    }
}
