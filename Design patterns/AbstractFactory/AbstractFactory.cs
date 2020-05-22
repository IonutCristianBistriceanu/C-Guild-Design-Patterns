using System;
using System.Collections.Generic;

namespace Design_patterns.AbstractFactory
{
    public interface IHotDrink
    {
        void Consume();
    }

    internal class Tea : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This tea is very good");
        }
    }


    internal class Coffee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This coffee is really good");
        }
    }

    public interface IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount);
    }

    internal class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Process for making tea in the amount of {amount} ml");
            return new Tea();
        }
    }

    internal class CoffeeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Process for making coffee in the amount of {amount} ml");
            return new Coffee();
        }
    }

    public class HotDrinksMachine
    {
        public enum AvailableDrink
        {
            Tea,
            Coffee
        }

        private Dictionary<AvailableDrink, IHotDrinkFactory> _factories =
            new Dictionary<AvailableDrink, IHotDrinkFactory>();


        public HotDrinksMachine()
        {
            foreach (AvailableDrink drink in Enum.GetValues(typeof(AvailableDrink)))
            {
                var factory = (IHotDrinkFactory) Activator.CreateInstance(
                    Type.GetType("Design_patterns." + Enum.GetName(typeof(AvailableDrink), drink) + "Factory"));

                _factories.Add(drink, factory);
            }
        }

        public IHotDrink MakeDrink(AvailableDrink drink, int amount)
        {
            return _factories[drink].Prepare(amount);
        }
    }
}