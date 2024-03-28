namespace P10_Zusatz_Project_Students
{
    internal class Student
    {

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string FirstName { get; private set; }
        public float GradeAverage { get; set; }

        public Student(int id, string name, string firstName, float notendurchschnitt)
        {
            Id = id;
            Name = name;
            FirstName = firstName;
            GradeAverage = notendurchschnitt;
        }
    }
}
