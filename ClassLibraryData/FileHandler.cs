using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using ClassLibraryMyBikes;
using System.IO;

namespace ClassLibraryData
{
    public class FileHandler
    {
        private static String binFilePath = @"../../../ClassLibraryData/data/bikes.ser";

        public static void WriteToSerializedFile(List<Bike> listOfBikes)
        {
            FileStream fs = new FileStream(binFilePath, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, listOfBikes);
            fs.Close();

        }
        public static List<Bike> ReadFromSerializedFile()
        {
            List<Bike> tempList = new List<Bike>();

            if (File.Exists(binFilePath))
            {
                FileStream fs = new FileStream(binFilePath, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();

                tempList = (List<Bike>)bf.Deserialize(fs);

                fs.Close();

            }
            return tempList;
        }
    }
}
