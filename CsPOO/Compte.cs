namespace CsPOO
{
    internal abstract class Compte
    {
        public Compte()
        {
            number = ++lastNumber + "";
        }


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

        //private string agence = "";
        //public string Agence
        //{
        //    get { return agence; }
        //    set { agence = value; }
        //}
        public abstract void AbstractMethod();


        private static int lastNumber = 0;
        public string number;
        public string Number
        {
            get
            {
                return "CPT" + number.PadLeft(9, '0');
            }
        }

        private Client? titulaire;
        public Client? Titulaire
        {
            get => titulaire;
            set
            {
                if (titulaire != value)
                {
                    titulaire?.RemoveCompte(this);
                    titulaire = value;
                    titulaire?.AddCompte(this);
                }
            }
        }
        public string Devise { get; set; } = "€";
        public double Solde { get; set; }


        public void Crediter(double amount)
        {
            Solde += amount;
        }

        public virtual void Debiter(double amount)
        {
            if (Solde - amount >= 0)
            {
                Solde -= amount;
            }
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
