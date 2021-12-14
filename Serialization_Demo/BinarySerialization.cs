using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

////serailization------converting object to byte stream and store in a file
namespace Serialization_Demo
{
    class BinarySerialization
    {
        ////non-static method
        public void Serialization()
        {
            Demo sample = new Demo();

            //if Example1.txt exists then it will overwrite otherwise it will create, and used the enum class Filemode(Filemode.Create)
            FileStream fileStream = new FileStream(@"C:\Users\Afiyat Khan\source\repos\File_IO_Demo\Serialization_Demo\TextFile1.txt", FileMode.Create);

            ////serialize is a nonstatic method thats why we are creating a object of binaryformatter
            ////also present in Binaryformatter class thats why we are creating object of that class
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, sample);
            Console.ReadKey();
        }
    }

    [Serializable] ////it is the serializable attribute indicates to the class Demo like the [TestMethod]
    public class Demo
    {
        //this (get set) can overwrite if we pass some value while calling
        //otherwise it will take default value which we intialized here 
        public string ApplicationName  = "Binary ";
        public int ApplicationId  = 1002;
    }
}