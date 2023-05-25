using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOStream
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileIO fileIO = new FileIO();
            Binary binary=new Binary();
            Console.WriteLine("Choose the option");
            Console.WriteLine("1.File exists\n2.Read all text\n3.Read all lines\n4.Copy file\n5.Delete file\n6.Read from stream reader\n7.Read from stream writer\n8.Binary Serialization");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    fileIO.FileExists();
                    break;
                    case 2:
                    fileIO.ReadAllText();
                    break;
                    case 3:
                    fileIO.ReadAllLines();
                    break;
                    case 4:
                    fileIO.FileCopy();
                    break;
                    case 5:
                    fileIO.DeleteFile();
                    break;
                    case 6:
                    fileIO.ReadFromStreamReader();
                    break;
                    case 7:
                    fileIO.ReadFromStreamWriter();
                    break;
                    case 8:
                    binary.BinarySerialization();
                    break;
            }
            Console.ReadLine();
        }
    }
}
