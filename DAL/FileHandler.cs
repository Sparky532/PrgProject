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

        public FileHandler(string fileParam = "Problems.txt")
        {
            this.filePath = fileParam;
        }

        public void WriteData(string toWrite)
        {
            try
            {
                if (!(File.Exists(filePath)))
                {
                    stream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                }
                stream = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                writer = new StreamWriter(stream);
                writer.WriteLine(toWrite);
                writer.Flush();
            }
            catch (FileNotFoundException)
            {
                FileHandler handler = new FileHandler();
                handler.WriteData("File: " + this.filePath + "was not found at: " + DateTime.UtcNow.ToShortDateString() + " " + DateTime.UtcNow.ToShortTimeString());
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory(filePath);
                FileHandler handler = new FileHandler();
                handler.WriteData("Directory for: " + this.filePath + "was not found at: " + DateTime.UtcNow.ToShortDateString() + " " + DateTime.UtcNow.ToShortTimeString());
            }
            catch (IOException e)
            {
                FileHandler handler = new FileHandler();
                handler.WriteData("Exception: " + e.ToString() + "was caught at: " + DateTime.UtcNow.ToShortDateString() + " " + DateTime.UtcNow.ToShortTimeString());
            }
            finally
            {
                writer.Close();
                stream.Close();
            }
        }
    }
}
