﻿namespace lab2
{

    class Product
    {
        string name, date;
        int art;
        float price;
        private bool _status;
        bool send;
        private int[] arr = new int[] { 1, 2, 3, 4, 5 };
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

        public Product(string name, int art, float price, string date)
        {
            this.name = name;
            this.art = art;
            this.price = price;
            this.date = date;
        }
        public Product()
        {
            this.name = "";
            this.art = 0;
            this.price = 0;
            this.date = "";
        }
        /* */
        public virtual void Print()
        {
            Console.WriteLine("Название товара : " + name);
            Console.WriteLine("Артикул товара : " + art);
            Console.WriteLine("Цена товара : " + price);
            Console.WriteLine("Дата создания товара : " + date);
            Console.WriteLine("");
        }
        public void Sendproduct()
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
    class Ball : Product
    {
        string color;
        public Ball(string color, string name, int art, float price, string date) : base(name, art, price, date)
        {
            this.color = color;
        }
        public override void Print()
        {
            Console.WriteLine("Цвет товара : " + color);
            base.Print();
        }
    }

    class NewClass
    {
        static void Main()
        {
            Product Phone = new Product("domashni", 7475, 4321, "10.10.2022");
            Ball Red = new Ball("Red", "Cool ball", 23196, 10, "11.11.2022");
            Phone.Status = true;
            Phone.Sendproduct();
            Red.Print();
        }
    }

}