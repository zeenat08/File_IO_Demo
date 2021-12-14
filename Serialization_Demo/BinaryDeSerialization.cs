using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

////deserialization-----byte stream to object from the file
namespace Serialization_Demo
{
    class BinaryDeSerialization
    {
        ////non-static method
        public void DeSerialization()
        {
            ////here we are just opening the file by giving the path, and used the enum class Filemode(filemode.open)
            FileStream fileStream = new FileStream(@"C:\Users\Afiyat Khan\source\repos\File_IO_Demo\Serialization_Demo\TextFile1.txt", FileMode.Open);

            ////Deserialize is a nonstatic method thats why we are creating a object of binaryformatter
            ////also present in Binaryformatter class thats why we are creating object of that class
            BinaryFormatter formatter = new BinaryFormatter();

            ////casting to Demo and giving reference with a (variable-deserializationdemo)..otherwise Garbage Col. will remove that who have no reference
            Demo deserializationdemo = (Demo)formatter.Deserialize(fileStream);

            ////here it will print by converting the bytes to object which we passed in the Demo class properties
            Console.WriteLine($"Application name- {deserializationdemo.ApplicationName} \nApplicationId-    {deserializationdemo.ApplicationId}");
            Console.ReadKey();
        }
    }
}