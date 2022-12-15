namespace CsPOO
{
    internal class Client : IEquatable<Client>, IClonable<Client>
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

        private string number;
        public string Number
        {
            get
            {
                return "C" + number.PadLeft(9, '0');
            }
        }

        public List<Compte> CompteList { get; private set; } = new List<Compte>();

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
            if (compte != null && CompteList.Contains(compte))
            {
                CompteList.Remove(compte);
                if (compte.Titulaire == this)
                {
                    compte.Titulaire = null;
                }
            }
        }

        public override string ToString()
        {
            return Gender + " "
                + Lastname.ToUpper() + " "
                + char.ToUpper(Firstname[0]) + Firstname.Substring(1).ToLower() + " (N° "
                + Number + ")";

        }

        public bool Equals(Client? other)
        {
            return Number == other.Number;
        }

        public Client Clone(Client other)
        {
            return new Client() { Birthdate = Birthdate, CompteList = CompteList, Firstname = Firstname };
        }
    }

    public enum Gender
    {
        Mr, Mme, X
    }


}
