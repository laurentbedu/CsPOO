namespace CsPOO
{
    internal class Compte
    {
        //public Compte()
        //{
        //    bool stop = true;
        //}
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


        public string Titulaire { get; set; } = "";
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
            return Titulaire + " (" + Solde + Devise + ")";
        }

        public bool Equals(Compte obj)
        {
            return Titulaire == obj.Titulaire;
        }


    }
}
