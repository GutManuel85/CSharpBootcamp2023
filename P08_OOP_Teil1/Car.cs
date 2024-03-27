namespace P08_OOP_Teil1
{
    internal class Car
    {
        // fields with default access modifier 'private'
        string brand;
        string model;
        int year;

        //Properties
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }

        public float ConsumptionPer100Km { get; private set; }

        public Car(string brand, string model, int year, float consumptionPer100Km)
        {
            Brand = brand;
            Model = model;
            Year = year;
            ConsumptionPer100Km = consumptionPer100Km;
        }

        public void Honk()
        {
            Console.WriteLine("Car honks.");
        }

        public string GetFullInfo()
        {
            return $"{Brand} | {Model} | {Year}";
        }

        public float CalculateFuelConsumption(int kilometers)
        {
            return kilometers * ConsumptionPer100Km / 100;
        }
    }
}
