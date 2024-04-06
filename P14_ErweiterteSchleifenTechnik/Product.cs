namespace P14_ErweiterteSchleifenTechnik
{
    internal class Product
    {
        public string Name { get; private set; }
        public List<int> Ratings { get; private set; }

        public Product(string name, List<int> ratings)
        {
            this.Name = name;
            this.Ratings = ratings;
        }

    }
}
