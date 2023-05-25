using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOStream
{
    public class FileIO
    {
        string filePath = "C:\\DemoMansi\\FileIOStream\\FileIOStream\\FileOperations\\Operation.txt";
        public void FileExists()
        {
            if(File.Exists(filePath))
            {
                Console.WriteLine("File is present");
            }
            else
            {
                Console.WriteLine("File is not present");
            }
        }
        //read the data in single string
        public void ReadAllText()
        {
            string line = File.ReadAllText(filePath);
            Console.WriteLine(line);
        }
        //read the data in line by line
        public void ReadAllLines()
        {
            string[] strings= File.ReadAllLines(filePath);
            foreach(string line in strings)
            {
                Console.WriteLine(line);
            }
        }
        public void FileCopy()
        {
            string copyPath = "C:\\DemoMansi\\FileIOStream\\FileIOStream\\FileOperations\\OperationNew.txt";
            File.Copy(filePath, copyPath);
            Console.WriteLine("File is copied");
        }
        public void DeleteFile()
        {
            string copyPath = "C:\\DemoMansi\\FileIOStream\\FileIOStream\\FileOperations\\OperationNew.txt";
            File.Delete(copyPath);
            Console.WriteLine("File is deleted");
        }
        public void ReadFromStreamReader()
        {
            using (StreamReader sr = File.OpenText(filePath))
            {
                string text = "";
                while((text= sr.ReadLine()) != null)
                {
                    Console.WriteLine(text);
                }
            }
        }
        public void ReadFromStreamWriter()
        {
            using (StreamWriter sw=File.AppendText(filePath))
            {
                sw.WriteLine("This is stream writer operation");
                sw.Close();
                Console.WriteLine(File.ReadAllText(filePath));
            }
        }
    }
}
