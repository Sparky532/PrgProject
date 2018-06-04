using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace HelperLibrary
{
    public static class SerializationHelper
    {
        public static byte[] BinarySerialization(this object dataToSerialize)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            byte[] dataSerialized = new byte[1024];

            try
            {
                formatter.Serialize(stream,dataToSerialize);
                dataSerialized = stream.GetBuffer();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                stream.Close();
            }
            return dataSerialized;
        }
        public static object BinaryDeserialization(this byte[] dataToDeserialize)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream(dataToDeserialize);
            object dataDeserialized = new object();

            try
            {
                dataDeserialized = formatter.Deserialize(stream);
            }
            catch (Exception)
            {
              //  throw;
            }
            finally
            {
                stream.Close();
            }
            return dataDeserialized;
        }

        public static void XMLSerialization(this object dataToSerialize, string filepath)
        {
            FileStream stream = null;
            try
            {
                Type type = dataToSerialize.GetType();
                XmlSerializer serializer = new XmlSerializer(type);

                stream = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);

                serializer.Serialize(stream, dataToSerialize);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                stream.Close();
            }
        }
        public static object XMLDeserialization(this object dataToSerialize, string filepath)
        {
            FileStream stream = null;
            try
            {
                Type type = dataToSerialize.GetType();
                XmlSerializer serializer = new XmlSerializer(type);

                stream = new FileStream(filepath, FileMode.Open, FileAccess.Read);

                dataToSerialize = serializer.Deserialize(stream);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                stream.Close();
            }
            return dataToSerialize;
        }
    }
}

