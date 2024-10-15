namespace HomeWork4._4
{
    public partial class MainPage : ContentPage
    {
        private List<Product> products = new List<Product>();

        public MainPage()
        {
            InitializeComponent();
            InitializeProducts();
            DisplayProducts();
        }
        private void InitializeProducts()
        {
            products.Add(new FoodProduct("Milk", 25, "Ukraine", DateTime.Now.AddDays(-1), "Tasty milk", DateTime.Now.AddDays(7), 1, "l"));
            products.Add(new Book("Programming book", 350, "USA", DateTime.Now.AddDays(-10), "C# Programming book", 520, "A", new List<string> { "Televnyi Anton", "Vykvonates Bohdan" }));
        }
        private void DisplayProducts()
        {
            ProductsGrid.Clear();

            int row = 1;

            foreach (var product in products)
            {
                ProductsGrid.Add(new Label { Text = product.Name }, 0, row);
                ProductsGrid.Add(new Label { Text = product.Price.ToString("C") }, 1, row);
                ProductsGrid.Add(new Label { Text = product.CountryOfOrigin }, 2, row);
                ProductsGrid.Add(new Label { Text = product.Description }, 3, row);
                row++;
            }
        }
        private void OnAddProductClicked(object sender, EventArgs e)
        {
            products.Add(new FoodProduct("Apple", 10, "Ukraine", DateTime.Now, "tasty green apple", DateTime.Now.AddDays(14), 1, "kg"));
            DisplayProducts();
        }
        private void OnDeleteProductClicked(object sender, EventArgs e)
        {
            if (products.Count > 0)
            {
                products.RemoveAt(products.Count - 1);
                DisplayProducts();
            }
        }

    }

}
