namespace P04_Array
{
    internal class P04_Array
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello from ArrayDemo");

            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Auf Element in Array zugreifen
            Console.WriteLine(numbers[1]);

            // Länge des Arrays ausgeben
            Console.WriteLine(numbers.Length);

            // Neue Werte zuweisen
            numbers[1] = 99;
            Console.WriteLine(numbers[1]);

            // Array sortieren
            int[] unsortedNumbers = new int[5];
            unsortedNumbers[0] = 200;
            unsortedNumbers[1] = 100;
            unsortedNumbers[2] = 400;
            unsortedNumbers[3] = 300;
            unsortedNumbers[4] = 500;

            Array.Sort(unsortedNumbers);

            Console.WriteLine("Now, the array is sorted");
            foreach (int number in unsortedNumbers)
            {
                Console.WriteLine(number);
            }

            // Durch Array iterieren

            // Mit for Loop
            int sum = 0;
            for (int i = 0; i < unsortedNumbers.Length; i++)
            {
                sum += unsortedNumbers[i];
            }
            Console.WriteLine(sum);

        }
    }
}
