using System.IO;
using System.Text;

namespace Genius.Common
{
    public static class FileProvider
    {
        public static void Save(string path, string value, bool append = false)
        {
            using (StreamWriter streamWriter = new StreamWriter(path, append, Encoding.UTF8))
            {
                streamWriter.WriteLine(value);
            }
        }

        public static bool IsExist(string path)
        {
            return File.Exists(path);
        }

        public static void Create(string path)
        {
            using (FileStream _ = File.Create(path))
            {

            }
        }

        public static string GetValue(string path)
        {
            using (StreamReader streamReader = new StreamReader(path, Encoding.UTF8))
            {
                return streamReader.ReadToEnd();
            }
        }
    }
}
