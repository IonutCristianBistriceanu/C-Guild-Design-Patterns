using Design_patterns.AbstractFactory;

namespace Design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var hotDrinksMachine = new HotDrinksMachine();
            hotDrinksMachine.MakeDrink(HotDrinksMachine.AvailableDrink.Tea, 100);
            hotDrinksMachine.MakeDrink(HotDrinksMachine.AvailableDrink.Coffee, 200);
        }
    }
}