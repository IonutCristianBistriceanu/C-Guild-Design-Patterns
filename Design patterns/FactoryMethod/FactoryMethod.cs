using System;

namespace Design_patterns.FactoryMethod
{
    //Generic Factory method with Creator abstract class

    public interface IProduct
    {
        string Operation();
    }

    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            var product = FactoryMethod();
            return product.Operation();
        }
    }


    public class Creator1 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new Product1();
        }
    }

    public class Creator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new Product2();
        }
    }


    public class Product1 : IProduct
    {
        public string Operation()
        {
            return "product1";
        }
    }

    public class Product2 : IProduct
    {
        public string Operation()
        {
            return "product2";
        }
    }

    public class Client
    {
        public void Main()
        {
            Console.WriteLine("App launched with ConcreteCreator1");
            ClientCode(new Creator1());

            Console.WriteLine("App launched with ConcreteCreator2");
            ClientCode(new Creator2());
        }

        private void ClientCode(Creator creator)
        {
            Console.WriteLine(creator.SomeOperation());
        }
    }
}