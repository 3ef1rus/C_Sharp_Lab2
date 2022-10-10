using Phone_lab2;
using GetColor_lab2;

namespace Ball_lab2
{
    class Ball : Phone,GetColor
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
        public void Color(){
            Console.WriteLine("Название товара : " + this.color);
        }
    }
}