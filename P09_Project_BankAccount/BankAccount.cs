namespace P09_Project_BankAccount
{
    internal class BankAccount
    {

        public string Number { get; private set; }

        public string Owner { get; private set; }

        public float Balance { get; private set; }

        public string Pin {  get; private set; }

        public BankAccount(string number, string owner, float balance, string pin)
        {

            Number = number;
            Owner = owner;
            Balance = balance;
            Pin = pin;
        }

        public void MakeDeposite(float depositAmount)
        {
            Balance += depositAmount;
            Console.WriteLine($"Der neue Kontostand ist CHF {Balance}.");
        }

        public void MakeWithdraw(float withdrawAmount)
        {
            if (Balance >= withdrawAmount)
            {
                Balance -= withdrawAmount;
                Console.WriteLine($"Der neue Kontostand ist CHF {Balance}.");
            }
            else
            {
                Console.WriteLine("Unzureichender Kontostand.");
            }
        }

        public void PrintBalance()
        {
            Console.WriteLine($"Kontonummer: {Number} | Kontoinhaber: {Owner} | Kontostand: {Balance}");
        }

    }
}
