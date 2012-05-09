using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Diploma
{
    public class SerializationData
    {
        public List<Node> Nodes;

        public static bool Serialize(string fileName, SerializationData data)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(SerializationData));
            TextWriter textWriter = new StreamWriter(fileName);
            xmlSerializer.Serialize(textWriter, data);
            textWriter.Close();

            return true;
        }

        public static bool Deserialize(string fileName, out SerializationData data)
        {
            if (!File.Exists(fileName))
            {
                data = null;
                return false;
            }

            XmlSerializer xmlDeserializer = new XmlSerializer(typeof(SerializationData));
            TextReader textReader = new StreamReader(fileName);
            data = xmlDeserializer.Deserialize(textReader) as SerializationData;
            textReader.Close();

            return true;
        }
    }
}
