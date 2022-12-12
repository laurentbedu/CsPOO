namespace CsPOO
{
    internal class Compte
    {
        public Compte()
        {
            number = ++lastNumber + "";
        }

        private static int lastNumber = 0;
        //public Compte(string titulaire)
        //{
        //    this.titulaire = titulaire;
        //}

        //public Compte(string titulaire, string devise)
        //{
        //    this.titulaire = titulaire;
        //    this.devise = devise;
        //}


        //string titulaire = "";
        //string devise = "€";
        //double solde;

        private string agence = "";
        public string Agence
        {
            get { return agence; }
            set { agence = value; }
        }

        public string number;
        public string Number
        {
            get
            {
                return "CPT" + number.PadLeft(9, '0');
            }
        }


        public Client? Titulaire { get; set; }
        public string Devise { get; set; } = "€";
        public double Solde { get; set; }


        public void Crediter(double amount)
        {
            Solde += amount;
        }

        public void Debiter(double amount)
        {
            Solde -= amount;
        }

        public override string ToString()
        {
            return Number + " (" + Solde + Devise + ")";
        }

        //public bool Equals(Compte obj)
        //{
        //    return Titulaire == obj.Titulaire;
        //}


    }
}
