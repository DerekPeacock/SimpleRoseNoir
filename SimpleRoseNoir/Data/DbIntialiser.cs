using SimpleRoseNoir.Models;

namespace SimpleRoseNoir.Data
{
    public static class DbIntialiser
    {
        public static void SeedData(ApplicationDbContext context)
        {
            AddProducts(context);
            AddVariations(context);
        }


        private static void AddProducts(ApplicationDbContext context)
        {
            if(context.Products.Any())
            {
                return;
            }

            var products = new Product[]
            {
                new Product()
                {
                     Name = "Product 1",
                     Description = "Product 1 descriptiom ",
                     Price = 21.00m,
                },
                 new Product()
                {
                     Name = "Product 2",
                     Description = "Product 2 descriptiom ",
                     Price = 22.00m,
                },
            };

            foreach ( var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
        private static void AddVariations(ApplicationDbContext context)
        {
            if (context.Variations.Any())
            {
                return;
            }

            var variations = new Variation[]
            {
                new Variation()
                {
                    Name = "Yellow Product 1",
                    Description = "Yellow Product 1 Description",
                    Colour ="Yellow",
                    Price = 0
                },
                new Variation()
                {
                    Name = "Blue Product 1",
                    Description = "Blue Product 1 Description",
                    Colour ="Blue",
                    Price = 0
                }
            };
        }
    }
}
