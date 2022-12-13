namespace CsPOO
{
    internal class Product
    {
        public string Ref { get; set; } = "";
        public string Label { get; set; } = "";
        public double Price { get; set; }

        private Category? category;
        public Category? Category
        {
            get => category;
            set
            {
                if (category != value)
                {
                    category?.RemoveProduct(this);
                    category = value;
                    category?.AddProduct(this);
                }
            }
        }

        public override string ToString()
        {
            return Label + " (Réf:" + Ref + ") : " + Price + "€HT (" + Category + " )";
        }
    }
}
