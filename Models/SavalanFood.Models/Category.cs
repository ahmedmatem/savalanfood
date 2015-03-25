namespace SavalanFood.Models
{
    using System;
    using System.Collections.Generic;

    using SavalanFood.Common;


    public class Category
    {
        public Category()
        {
            this.Id = RandomKeyGenerator.GenerateKey();
            this.Products = new HashSet<Product>();
        }

        public string Id { get; set; }

        public string ParentId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}