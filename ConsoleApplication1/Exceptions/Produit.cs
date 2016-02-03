namespace Exceptions
{
    public class Produit
    {
        private int stock;

        public int _stock
        {
            get { return stock; }
            set { stock = value; }
        }


        public Produit(int monstock)
        {
            _stock = monstock;
        }
    }
}