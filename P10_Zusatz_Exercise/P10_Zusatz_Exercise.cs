namespace P10_Zusatz_Exercise
{
    internal class P10_Zusatz_Exercise
    {

        List<int> list = new List<int>();

        public void AddNumber(int number)
        {
            list.Add(number);
        }

        public float CalculateAverage()
        {
            float sum = 0f;
            foreach (int element in list)
            {
                sum += element;
            }
            return sum / list.Count;
        }

        static void Main(string[] args)
        {
            P10_Zusatz_Exercise ex = new P10_Zusatz_Exercise();
            ex.AddNumber(3);
            ex.AddNumber(4);
            ex.AddNumber(6);
            Console.WriteLine(ex.CalculateAverage());

        }
    }


}
