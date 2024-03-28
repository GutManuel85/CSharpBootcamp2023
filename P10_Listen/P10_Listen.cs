namespace P10_Listen
{
    internal class P10_Listen
    {

        static void Main(string[] args)
        {

            //************************ Beispiel mit Zahlen ******************************

            // Array hat statische Grösse
            int[] numbers = new int[3] { 1, 2, 3 };

            // List hat dynamische Grösse. Hier wird neue Liste erstellt;
            List<int> ints = new List<int>();

            // Hinzufügen
            ints.Add(500);

            // Hinzufügen an bestimmter Stelle
            ints.Insert(0, 400);

            // Grösse der Liste (mithilfe des Count Property)
            int numberOfElements = ints.Count;

            string message = $"Die Liste hat {numberOfElements} Elemente";
            Console.WriteLine(message);

            PrintList(ints);

            // Entfernen (entfernt erstes vorkommendes Element. Der Rest rückt eins nach vorne.)
            bool success = ints.Remove(400);

            PrintList(ints);

            // Index holen
            int index = ints.IndexOf(500);

            // Entfernen an bestimmter Stelle (Der Rest rückt eins nach vorne.)
            ints.RemoveAt(index);


            // Löscht den ganzen Listeninhalt
            ints.Clear();


            //************************ Beispiel mit Namen ******************************

            List<string> names = new List<string>() { "Manuel", "Hans", "Max" };

            names.Add("John");

            // Auf Element an index 1 zugreifen und Element ersetzen
            names[1] = "Maria";

            PrintList(names);













        }

        // Methode verwendet Generics (kommt später). Dadurch können in unserem Beispiel sowohl Listen mit int und mit string verwendet werden
        static void PrintList<T>(List<T> list)
        {
            Console.WriteLine("Printed List:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"Index: {i} | Content: {list[i]}");
            }
        }

    }
}
