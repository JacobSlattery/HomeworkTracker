using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HomeworkTracker.FileIO
{
    /// <summary>
    ///     Used for XML serialization of the TabControl.
    /// </summary>
    public class TabControlSerializer
    {
        #region Methods

        /// <summary>
        ///     Serializes the specified <see cref="TabControl" /> to the xml file by using a
        ///     <see cref="TabControlTransferObject" />.
        /// </summary>
        /// <param name="filename">The filename saved to.</param>
        /// <param name="tabControl">The TabControl serialized.</param>
        public static void SerializeTabControlToXml(string filename, TabControl tabControl)
        {
            var container = new TabControlTransferObject();
            container.Save(tabControl);

            using (var writer = new StreamWriter(filename, false))
            {
                var serializer = new XmlSerializer(typeof(TabControlTransferObject));
                serializer.Serialize(writer, container);
                writer.Flush();
            }
        }

        /// <summary>
        ///     Deserializes the xml file to update the TabControl by using a <see cref="TabControlTransferObject" />.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <param name="tabControl">The TabControl deserialized.</param>
        public static void DeserializeXmlFileToTabControl(string filename, TabControl tabControl)
        {
            using (var stream = File.OpenRead(filename))
            {
                var serializer = new XmlSerializer(typeof(TabControlTransferObject));
                var dataTransferObject = serializer.Deserialize(stream) as TabControlTransferObject;
                dataTransferObject?.LoadTo(tabControl);
            }
        }

        #endregion
    }
}