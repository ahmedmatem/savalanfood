namespace SavalanFood.Models
{
    using SavalanFood.Common;

    public class Product
    {
        public Product()
        {
            this.Id = RandomKeyGenerator.GenerateKey();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public string CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
