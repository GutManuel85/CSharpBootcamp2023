namespace P12_Quiz_Klasse
{
    public class Question
    {
        public string QuestionSentence { get; private set; }
        public List<string> Options { get; private set; }
        public int CorrectAnwerNumber { get; private set; }
        public int Points { get; private set; }

        public Question(string question, List<string> options, int correctAnwerNumber)
        {
            QuestionSentence = question;
            this.Options = options;
            this.CorrectAnwerNumber = correctAnwerNumber;
        }

        public int guessAnswer()
        {
            printQuestion();
            printOptions();
            this.Points = this.Options.Count - 1;
            while (true)
            {
                Console.WriteLine("Bitte Nummer deiner Antwort eingeben:");
                int optionNumber = int.Parse(Console.ReadLine());
                string guessedAnwer = this.Options[optionNumber - 1];
                if (optionNumber == this.CorrectAnwerNumber)
                {
                    Console.WriteLine($"{guessedAnwer} ist korrekt!");
                    return Points;
                }
                else
                {
                    Console.WriteLine($"{guessedAnwer} ist leider falsch. Versuch's nochmals!");
                    if (Points > 0)
                    {
                        Points--;
                    }
                }
            }
        }

        public void printQuestion()
        {
            Console.WriteLine(this.QuestionSentence);
        }

        public void printOptions()
        {
            int counter = 1;
            foreach (string option in this.Options)
            {
                Console.WriteLine($"Antwort {counter} : {option}");
                counter++;
            }
        }
    }
}
