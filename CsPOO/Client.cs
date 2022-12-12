namespace CsPOO
{
    internal class Client
    {
        public Client()
        {
            number = ++lastNumber + "";
        }

        private static int lastNumber = 0;
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Gender Gender { get; set; }
        public DateTime Birthdate { get; set; }

        public string number;
        public string Number
        {
            get
            {
                return "C" + number.PadLeft(9, '0');
            }
        }

        public List<Compte> CompteList { get; set; } = new List<Compte>();

        public void AddCompte(Compte compte)
        {
            if (!CompteList.Contains(compte))
            {
                CompteList.Add(compte);
            }
            if (compte.Titulaire != this)
            {
                compte.Titulaire = this;
            }


        }

        public void RemoveCompte(Compte compte)
        {
            if (CompteList.Contains(compte))
            {
                CompteList.Remove(compte);
            }
            if (compte.Titulaire == this)
            {
                compte.Titulaire = null;
            }
        }

        public override string ToString()
        {
            return Gender + " "
                + Lastname.ToUpper() + " "
                + char.ToUpper(Firstname[0]) + Firstname.Substring(1).ToLower() + " (N° "
                + Number + ")";

        }

    }

    public enum Gender
    {
        Mr, Mme, X
    }


}
