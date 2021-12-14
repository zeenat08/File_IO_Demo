using System;

namespace Serialization_Demo
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serialization and Deserialization\n");
            BinarySerialization obj = new BinarySerialization();
            //obj.Serialization();
            BinaryDeSerialization obj1 = new BinaryDeSerialization();
            obj1.DeSerialization();
        }

    }
}
