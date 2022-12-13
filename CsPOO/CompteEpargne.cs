namespace CsPOO
{
    internal class CompteEpargne : Compte
    {
        public double TxInterest { get; set; }

        public bool isBlocked { get; set; }

        public void AddInterests(int nbDays)
        {
            double amount = Solde * TxInterest / 36500 * nbDays;
            Crediter(amount);
        }

        public override void Debiter(double amount)
        {
            if (!isBlocked)
            {
                base.Debiter(amount);
            }
        }

        public override void AbstractMethod()
        {

        }

    }
}
