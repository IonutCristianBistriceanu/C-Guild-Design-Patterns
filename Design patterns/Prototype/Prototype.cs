using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Design_patterns.Prototype
{
    //Common interface IClonable - Shallow or DeepCopy
    //Copy constructors (C++ reference) - Lets you specify an object to copy all the data from.
    //Not recognizable in the .NET C# setting
    //Explicit deep copy interface
    //Prototype pattern - Copy through serialization and limitations binary or XML

    public static class ExtentionMethods
    {
        public static T DeepCopy<T>(this T self)
        {
            //Memory stream
            var stream = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, self);
            stream.Seek(0, SeekOrigin.Begin);
            object copy = formatter.Deserialize(stream);
            stream.Close();
            return (T) copy;

            //Serialize

            //Return object
        }

        public static T DeepCopyXml<T>(this T self)
        {
            using (var stream = new MemoryStream())
            {
                var s = new XmlSerializer(typeof(T));
                s.Serialize(stream, self);
                stream.Position = 0;
                return (T) s.Deserialize(stream);
            }
        }
    }

    [Serializable]
    public class Person
    {
        public string Name;
        private Address Address;

        public Person()
        {
        }

        public Person(string name, Address address)
        {
            Name = name;
            Address = address;
        }


        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Address)}: {Address}";
        }
    }

    [Serializable]
    public class Address
    {
        public Address()
        {
        }

        public string Street;
        public int Number;

        public Address(string street, int number)
        {
            Street = street;
            Number = number;
        }


        public override string ToString()
        {
            return $"{nameof(Street)}: {Street}, {nameof(Number)}: {Number}";
        }
    }
}