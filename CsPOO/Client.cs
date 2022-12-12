namespace CsPOO
{
    internal class Client
    {
        public Client()
        {
            number = ++lastNumber + "";
        }

        public static int lastNumber = 0;
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Gender Gender { get; set; }
        public DateTime Birthdate { get; set; }

        public string number;
        public string Number { get { return "C" + number.PadLeft(9, '0'); } }

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
