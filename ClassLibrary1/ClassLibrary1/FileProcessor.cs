
namespace ClassLibrary
{
    public class FileProcessor
    {

        public static string ReadFromFile()
        {
            string fileName = "DataEntry.json";
            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\..\Data\JSON\", fileName);
            string sFilePath = Path.GetFullPath(path);

            using (var streamReader = new StreamReader(sFilePath))
                return streamReader.ReadToEnd();
        }

        public static void SaveToFile(string data)
        {
            string fileName = "DataEntry.json";
            string filePath = Path.Combine(Environment.CurrentDirectory, @"..\..\..\Data\JSON\");
            string filePathh = Path.Combine(filePath, fileName);

            if (File.Exists(filePathh))
            {
                File.Delete(filePathh);
            }

            string fullPath = Path.Combine(filePath, fileName);

            File.WriteAllText(fullPath, data);
        }

    }
}
