using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    [Table("Product")]
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }


        public void CreateList()
        {
            IDictionary<string, int> productDetails = new Dictionary<string, int>();
            productDetails.Add("Silk scarf", 15);
            productDetails.Add("Stone cup holders", 6);
            productDetails.Add("Statue flower vase", 25);
            productDetails.Add("Traditional romanian pattern puzzle", 17);
            productDetails.Add("Stone clock", 50);
            productDetails.Add("Green statue vase", 27);
            productDetails.Add("Drawing book with illustrations", 45);
            productDetails.Add("Green and gold tea set", 99);
            productDetails.Add("Golden Vase", 25);


            foreach (KeyValuePair<string, int> p in productDetails)
            {
                List<Products> products = new List<Products>();
                Products product = new Products();
                product.Name = p.Key;
                product.Price = p.Value;
                products.Add(product);
            }

        }
    }
}
