namespace P14_ErweiterteSchleifenTechnik
{
    internal class P14_ErweiterteSchleifenTechnik
    {

        static void Main(string[] args)
        {

            List<Product> products = new List<Product>();
            products.Add(new Product("Bratpfannte", new List<int>() { 1, 3, 3 }));
            products.Add(new Product("Toaster", new List<int>() { 5, 5, 4 }));
            products.Add(new Product("Mikrowelle", new List<int>() { 3, 4, 5, 5, 5 }));
            products.Add(new Product("Wasserkocher", new List<int>() { 2, 1 }));

            // Durchlaufen aller Produkte
            foreach (Product product in products) //<- outer loop
            {
                Console.WriteLine("******** Produkt: " + product.Name + " **********");
                double ratingSum = 0;
                int ratingAmount = product.Ratings.Count;

                for (int i = 0; i < ratingAmount; i++) //<- inner loop
                {
                    int productRating = product.Ratings[i];
                    Console.WriteLine($"Rating {i + 1}: {productRating}");
                    ratingSum += productRating;

                }
                Console.WriteLine($"Durchschnittliches Rating:{Math.Round(ratingSum / ratingAmount, 2)} ");
            }

            // Demo break und continue
            Console.WriteLine("********* Produkte filtern ***********");
            foreach (Product product in products)
            {
                if (product.Name.Equals("Toaster"))
                {
                    Console.WriteLine("Toaster habe ich schon. Weiter zum nächsten Produkt.");
                    continue;
                }
                foreach (int rating in product.Ratings)
                {
                    if (rating < 2)
                    {
                        Console.WriteLine($"Produkt {product.Name} hat mindestens eine 1-Sterne Bewertung => Abbruch");
                        break;
                    }
                }
            }
        }
    }
}
