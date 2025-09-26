namespace Bar_OO
{   
    internal class Bill
    {
        public char Gender;
        public int Beer;
        public int Barbecue;
        public int SoftDrink;

        public Bill()
        {
        }

        public Bill(char gender, int beer, int barbecue, int softDrink)
        {
            Gender = gender;
            Beer = beer;
            Barbecue = barbecue;
            SoftDrink = softDrink;
        }

        public double Cover()
        {
            if (Feeding() > 30) return 0;
            return 4;
        }

        public double Feeding()
        {
            return 5 * Beer + 3 * SoftDrink + 7 * Barbecue;
        }

        public double Ticket()
        {
            if (Gender == 'M') return 10;
            return 8;
        }

        public double Total()
        {
            return Cover() + Feeding() + Ticket();
        }
    }
}
