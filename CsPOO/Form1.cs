using System.Diagnostics;

namespace CsPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                long unixTimestamp = GetElapsedFromEpoch();
                string id = LongToString(unixTimestamp);
                Debug.WriteLine(id, unixTimestamp.ToString());
                //await Task.Delay(1000);
            }
            bool stop = true;
        }

        public static long GetElapsedFromEpoch(Elapsed elapsed = Elapsed.micro)
        {
            TimeSpan epochTicks = new TimeSpan(new DateTime(1970, 1, 1).Ticks);
            TimeSpan unixTicks = new TimeSpan(DateTime.Now.Ticks) - epochTicks;
            switch (elapsed)
            {
                case Elapsed.sec: return (long)unixTicks.TotalSeconds;
                case Elapsed.milli: return (long)unixTicks.TotalMilliseconds;
                //case Elapsed.micro: return(long)unixTicks.TotalMicroseconds;
                default: return (long)unixTicks.TotalMicroseconds;
            }
        }



        public static string LongToString(long value, string symbols = "0123456789abcdefghijklmnopqrstuvwxyz")
        {
            char[] baseChars = symbols.ToCharArray();
            string result = string.Empty;
            int targetBase = baseChars.Length;
            do
            {
                result = baseChars[value % targetBase] + result;
                value = value / targetBase;
            }
            while (value > 0);
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Compte cpt1 = new Compte();
            //Compte cpt2 = new Compte("Bédu Laurent");
            Compte cpt2 = new Compte() { Titulaire = "Bédu Laurent" };
            //Compte cpt3 = new Compte("John Doe", "$");
            Compte cpt3 = new Compte() { Titulaire = "John Doe", Devise = "$" };

            cpt2.Crediter(100);
            cpt2.Debiter(50);

            bool stop = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nb1 = 1;
            int nb2 = 2;
            nb2 = nb1;
            nb1 = 5;


            Compte cpt2 = new Compte() { Titulaire = "Bédu Laurent" };
            Compte cpt2save = cpt2;
            Compte cpt3 = new Compte() { Titulaire = "John Doe" };
            cpt2 = cpt3;
            cpt3.Solde = 100;
            bool stop = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Compte cptA = new Compte() { Titulaire = "John Doe" };
            Compte cptB = new Compte() { Titulaire = "John Doe" };

            bool cptAaqualsCptB = (cptA == cptB);
            bool cptAequalsCptB = cptA.Equals(cptB);

            cptA = cptB;
            cptAaqualsCptB = (cptA == cptB);

            string cptAStr = cptA.ToString();

            bool stop = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Client cl1 = new Client() { Firstname = "laurEnt", Lastname = "bédu", Gender = Gender.Mr };
            Client cl2 = new Client() { Firstname = "jane", Lastname = "dOe", Gender = Gender.Mme };
            Debug.WriteLine(cl1);
            Debug.WriteLine(cl2);
        }

    }

    public enum Elapsed
    {
        sec, milli, micro
    }
}