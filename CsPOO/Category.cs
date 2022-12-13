namespace CsPOO
{
    internal class Category
    {
        public string Code { get; set; } = "";
        public string Label { get; set; } = "";

        public List<Product> ProductList { get; } = new List<Product>();
        public void AddProduct(Product product)
        {
            if (!ProductList.Contains(product))
            {
                ProductList.Add(product);
            }
            if (product.Category != this)
            {
                product.Category = this;
            }
        }
        public void RemoveProduct(Product product)
        {
            if (product != null && ProductList.Contains(product))
            {
                ProductList.Remove(product);
                if (product.Category == this)
                {
                    product.Category = null;
                }
            }
        }

        public override string ToString()
        {
            return "Catégorie " + Label + " (" + Code + ")";
        }

        public string ProductListToString()
        {
            return String.Join('\n', ProductList);
        }


    }
}
