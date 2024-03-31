namespace P12_Quiz_Klasse
{
    public class Quiz
    {
        public int Points { get; set; }
        public List<Question> Questions { get; private set; }

        public Quiz()
        {
            this.Points = 0;
            this.Questions = new List<Question>();
        }

        public void playQuiz()
        {
            foreach (Question question in Questions)
            {
                this.Points += question.guessAnswer();
                Console.WriteLine("Question");
            }

            Console.WriteLine($"Du hast {this.Points} erreicht!");
        }
    }
}
