using System;
using System.Text;

public class Homework3
{
    private class Flower
    {
        public string Name { get; }
        public float Price { get; }

        public Flower(string name, float price)
        {
            Name = name;
            Price = price;
        }
    }

    private class Bouquet
    {
        public Flower[] Flowers { get; }

        public Bouquet(Flower[] flowers)
        {
            Flowers = flowers;
        }

        public float GetTotalPrice()
        {
            float sum = 0;
            foreach (Flower f in Flowers)
            {
                sum += f.Price;
            }

            return sum;
        }
    }

    public static void Solution()
    {
        Random random = new Random();

        Flower[] flowers = new Flower[]
        {
            new Flower("Tulip", 5.50f),
            new Flower("Rose", 6.75f),
            new Flower("Lily", 3.40f),
            new Flower("Poppy", 1.10f),
        };

        const int bouquetNumber = 4;
        const int flowersNumber = 10;
        Bouquet[] bouquets = new Bouquet[bouquetNumber];

        for (int i = 0; i < bouquetNumber; i++)
        {
            Flower[] bouquetFlowers = new Flower[10];
            for (int j = 0; j < flowersNumber; j++)
            {
                int randomIndex = random.Next(0, 4);
                bouquetFlowers[j] = flowers[randomIndex];
            }

            bouquets[i] = new Bouquet(bouquetFlowers);
        }

        for (int i = 0; i < bouquetNumber; i++)
        {
            int tulips = 0;
            int roses = 0;
            int lilies = 0;
            int poppies = 0;
            foreach (var flower in bouquets[i].Flowers)
            {
                switch (flower.Name)
                {
                    case "Tulip":
                        tulips++;
                        break;
                    case "Rose":
                        roses++;
                        break;
                    case "Lily":
                        lilies++;
                        break;
                    case "Poppy":
                        poppies++;
                        break;

                    default:
                        break;
                }
            }

            string bouquetDescription = $"Bouquet {i + 1}: ";
            if (tulips > 0)
                bouquetDescription += $" {tulips}x Tulip,";
            if (roses > 0)
                bouquetDescription += $" {roses}x Rose,";
            if (lilies > 0)
                bouquetDescription += $" {lilies}x Lilly,";
            if (poppies > 0)
                bouquetDescription += $" {poppies}x Poppy,";

            bouquetDescription += $", Total Price: ${bouquets[i].GetTotalPrice():f2}";
            Console.WriteLine(bouquetDescription);
        }
    }
}
