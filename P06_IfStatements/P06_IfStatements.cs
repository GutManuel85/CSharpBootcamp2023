namespace P06_IfStatements
{
    internal class P06_IfStatements
    {
        public static void Main(string[] args)
        {

            // Ist Zahl positiv?
            int number = 10;

            if (number > 0)
            {
                Console.WriteLine("positive Zahl");
            }
            else
            {
                Console.WriteLine("negative Zahl");
            }


            // Passwort
            string username = "Manuel";
            string password = "Password";
            if (username == "Manuel" && password == "Password")
            {
                Console.WriteLine("Credentials are correct");
            }
            else
            {
                Console.WriteLine("Access denied");
            }

            // Zahl beurteilen
            int positiveNumber = 1;

            if (positiveNumber >= 100)
            {
                Console.WriteLine("Nummer ist dreistellig");
            }
            else if (positiveNumber >= 10)
            {
                Console.WriteLine("Nummer ist zweistellig");
            }
            else
            {
                Console.WriteLine("Nummer ist einstellig");
            }


            // Rabatt erhalten?

            bool isStudent = true;
            bool hasCoupon = false;
            Console.WriteLine("Bitte Alter eingeben:");
            int age = int.Parse(Console.ReadLine());

            if ((isStudent && age < 20) || hasCoupon)
            {
                Console.WriteLine("Du erhälst den Rabatt");
            }
            else
            {
                Console.WriteLine("Leider kein Rabatt");
            }
        }


    }
}
