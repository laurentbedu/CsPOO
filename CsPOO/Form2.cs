using System.Diagnostics;

namespace CsPOO
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category cat1 = new Category() { Label = "Hi-Tech", Code = "Cat 01" };
            Category cat2 = new Category() { Label = "Divers", Code = "Cat 02" };
            Product prod1 = new Product() { Label = "Produit 1", Price = 100.00, Ref = "AZERTY" };
            Product prod2 = new Product() { Label = "Produit 2", Price = 99.00, Ref = "QSDFGH" };
            Product prod3 = new Product() { Label = "Produit 3", Price = 490.00, Ref = "WXCVBN" };

            cat1.AddProduct(prod1);
            cat2.AddProduct(prod2);
            cat1.AddProduct(prod3);
            bool stop = true;

            cat2.AddProduct(prod3);
            stop = true;

            prod3.Category = cat1;
            stop = true;

            Debug.WriteLine(cat1.ProductListToString());


        }

        private void button2_Click(object sender, EventArgs e)
        {
            CompteCourant cptCourant = new CompteCourant() { Solde = 0, DecouvertMax = 100 };
            cptCourant.Debiter(50);
            cptCourant.Debiter(200);

            CompteEpargne compteEpargne = new CompteEpargne() { Solde = 100, TxInterest = 2, isBlocked = false };
            compteEpargne.AddInterests(100);
            compteEpargne.Debiter(50);
            compteEpargne.Debiter(100);


            Client client = new Client();
            client.AddCompte(cptCourant);
            client.AddCompte(compteEpargne);
            bool stop = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsoleReader consoleReader = new ConsoleReader();
            FileReader fileReader = new FileReader() { Filename = "C:\\Temp\\test.txt" };

            List<IReadable> readableList = new List<IReadable>()
            {
                consoleReader,
                fileReader
            };

            foreach (var reader in readableList)
            {
                Console.WriteLine(reader.Read());
            }
        }
    }
}
