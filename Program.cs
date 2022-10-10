namespace lab2
{

    class Product
    {
        string name, date;
        int art;
        float price;

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
       /* public string name{ //getter and setter
            set{name=value;}
            get{return(name);}
        }*/
        
    }
    class Ball : Product
    {
        string color;
        public Ball(string color, string name, int art, float price, string date) : base(name, art, price, date)
        {
            this.color = color;
        }
    }

    class NewClass
    {
        static void Main()
        {


        }
    }

}