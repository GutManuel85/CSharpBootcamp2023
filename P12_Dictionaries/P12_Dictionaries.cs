namespace P12_Dictionaries
{
    internal class P12_Dictionaries
    {

        static void Main(string[] args)
        {
            // Englisch | Deutsch
            Dictionary<string, string> translations = new Dictionary<string, string>();
            translations.Add("house", "Haus");
            translations.Add("mouse", "Maus");
            translations.Add("man", "Mann");

            // Proudkt | Preis
            Dictionary<string, float> prices = new Dictionary<string, float>();
            prices.Add("Milk", 1.45f);
            prices.Add("Bread", 3.45f);
            prices.Add("Apfel 1kg", 4.5F);

            // Quiz
            Dictionary<string, string> quiz = new Dictionary<string, string>();
            quiz.Add("question", "Wie heisst Einstein zum Vornamen?");
            quiz.Add("option1", "Alfred");
            quiz.Add("option2", "Anton");
            quiz.Add("option3", "Albert");
            quiz.Add("numberOfcorrectAnswer", "option3");


            Dictionary<string, List<string>> otherQuiz =
                createQuiz("Welches ist die Hauptstadt der Schweiz?",
                new List<string>() { "Zürich", "Bern", "Genf" }, 2);

            printQuiz(otherQuiz);
        }


        private static Dictionary<string, List<string>> createQuiz(string question, List<string> options, int numberOfCorrectAnwer)
        {
            Dictionary<string, List<string>> quiz = new();
            quiz.Add("question", [question]);
            quiz.Add("options", options);
            quiz.Add("numberOfCorrectAnswer", [numberOfCorrectAnwer.ToString()]);

            return quiz;
        }

        private static void printQuiz(Dictionary<string, List<string>> quiz)
        {
            Console.WriteLine("************* QUIZ START ************");
            Console.WriteLine(quiz["question"][0]);
            foreach (string option in quiz["options"])
            {
                Console.WriteLine(option);
            }
            int correctAnswerNumber = int.Parse(quiz["numberOfCorrectAnswer"][0]);
            Console.WriteLine($"Die korrekte Antwort ist Antwort {correctAnswerNumber}: {quiz["options"][correctAnswerNumber - 1]}");
            Console.WriteLine("************* QUIZ END ************");

        }
    }
}
