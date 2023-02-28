using SimpleRoseNoir.Models;

namespace SimpleRoseNoir.Data
{
    public static class DbIntialiser
    {
        public static void SeedData(ApplicationDbContext context)
        {
            AddProducts(context);
        }

        private static void AddProducts(ApplicationDbContext context)
        {
            var products = new Product[]
            {

            };
        }
    }
}
