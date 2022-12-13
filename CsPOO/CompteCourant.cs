namespace CsPOO
{
    internal sealed class CompteCourant : Compte
    {
        public double DecouvertMax { get; set; }

        public override void Debiter(double amount)
        {
            if (Solde - amount >= -DecouvertMax)
            {
                Solde -= amount;
            }
        }

        public override void AbstractMethod()
        {

        }
    }
}
