using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIOStream
{
    public class Binary
    {
        string filePath = "C:\\DemoMansi\\FileIOStream\\FileIOStream\\FileOperations\\Operation.txt";
        public void BinarySerialization()
        {
            Test test= new Test();
            FileStream fileStream = new FileStream(@"C:\DemoMansi\FileIOStream\FileIOStream\FileOperations\TextFile.txt",FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream,test);
        }
    }
    [Serializable]
    class Test
    {
        public int Id { get; set; } = 121;
        public string Name { get; set; } = "Binary Serialization";
    }
}
