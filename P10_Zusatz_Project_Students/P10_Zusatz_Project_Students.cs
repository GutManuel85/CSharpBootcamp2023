namespace P10_Zusatz_Project_Students
{
    internal class P10_Zusatz_Project_Students
    {

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Mustermann", "Max", 5.2f));
            students.Add(new Student(2, "Meier", "Lena", 5.6f));
            students.Add(new Student(3, "John", "Doe", 4.6f));

            Console.WriteLine($" Der Notendurchschnitt aller Studenten ist {CalculateAverage(students)}");

        }

        static float CalculateAverage(List<Student> students)
        {
            float sum = 0f;
            foreach (Student student in students)
            {
                sum += student.GradeAverage;
            }
            return sum / students.Count;
        }
    }
}
