namespace P12_Quiz_Klasse
{
    internal class P12_Quiz_Klasse
    {

        static void Main(string[] args)
        {

            Quiz quiz = new Quiz();

            Question question1 = new Question("Wie heisst die Hauptstadt von Deutschland?",
                new List<string>() { "Hamburg", "Berlin", "Bonn" }, 2);

            quiz.Questions.Add(question1);

            Question question2 = new Question("Wie heisst die Hauptstadt von Frankreich?",
                new List<string>() { "Lyon", "Marseille", "Paris" }, 3);

            quiz.Questions.Add(question2);

            quiz.playQuiz();

        }
    }
}
