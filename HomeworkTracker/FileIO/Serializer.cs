using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using TrackerControlLibrary;

namespace HomeworkTracker.FileIO
{
    public class Serializer
    {
        public static void Serialize(string filename, TabControl tabControl)
        {
            var container = new DataTransferObject();
            container.Contain(tabControl);

            var writer = new StreamWriter(filename, false);
            var serializer = new XmlSerializer(typeof(DataTransferObject));
            serializer.Serialize(writer, container);
            writer.Flush();
            writer.Close();
        }


        public static void Deserialize(string filename, TabControl tabControl)
        {
            using (var stream = File.OpenRead(filename))
            {
                var serializer = new XmlSerializer(typeof(DataTransferObject));
                var dataTransferObject = serializer.Deserialize(stream) as DataTransferObject;
                dataTransferObject?.Update(tabControl);
            }
        }
    }
}
