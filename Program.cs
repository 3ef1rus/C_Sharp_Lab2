using Phone_lab2;
using Ball_lab2;
namespace lab2
{
    

    class NewClass
    {
        static void Main()
        {
            Phone Phone = new Phone("domashni", 7475, 4321, "10.10.2022");
            Ball Red = new Ball("Red", "Cool ball", 23196, 10, "11.11.2022");
            Phone.Status = true;
           // Phone[1]=0; //индексатор
            Phone.Sendproduct();
            Red.Print();
        }
    }

}