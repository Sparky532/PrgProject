using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FileHandler
    {
        string filePath = "";
        private FileStream stream;
        private StreamWriter writer;
        private StreamReader reader;

        public FileHandler(string fileParam = "SpeciesSuggestions.txt")
        {
            this.filePath = fileParam;
        }

        public void WriteData(string species)
        {
            try
            {
                if (!(File.Exists(filePath)))
                {
                    stream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                }
                stream = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                writer = new StreamWriter(stream);
                writer.WriteLine(species);
                writer.Flush();
            }
            catch (FileNotFoundException)
            {
                File.Create(filePath);
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory(filePath);
            }
            catch (IOException)
            {
                File.Create(filePath);
                File.AppendText(filePath);
            }
            finally
            {
                writer.Close();
                stream.Close();
            }
        }
    }
}
