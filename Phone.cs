using Shop_lab2;

namespace Phone_lab2
{
    class Phone : Shop
    {
        string name, date;
        int art;
        float price;
        private bool _status;

        private int[] arr = new int[] { 51, 2354, 6789, 2534, 7865 };
        bool send;
        public bool Status
        { //getter and setter
            get
            {
                return (_status);
            }
            set
            {
                _status = value;
            }
        }
        public int this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }
        public Phone(string name, int art, float price, string date)
        {
            this.name = name;
            this.art = art;
            this.price = price;
            this.date = date;
        }
        public Phone()
        {
            this.name = "";
            this.art = 0;
            this.price = 0;
            this.date = "";
        }
        public virtual void Print()
        {
            Console.WriteLine("Название товара : " + name);
            Console.WriteLine("Артикул товара : " + art);
            Console.WriteLine("Цена товара : " + price);
            Console.WriteLine("Дата создания товара : " + date);
            Console.WriteLine("");
        }
        public override void Sendproduct()
        {
            if (this.send == false)
            {
                this.send = true;
                Console.WriteLine("Товар с артикулом : " + art + " Отправлент");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Товар с артикулом : " + art + " Уже в пути");
                Console.WriteLine("");
            }
        }

    }
}