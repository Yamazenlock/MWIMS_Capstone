using System;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml;

namespace MWIMS_Capstone {

    static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeForm());

            SaveViaDataContractSerialization(Warehouse.Aisles, "warehouse.xml");

            Warehouse.Aisles = null;

        }

        static void SaveViaDataContractSerialization<T>(T serializableObject, string filepath) {
            var serializer = new DataContractSerializer(typeof(T));
            var settings = new XmlWriterSettings() {
                Indent = true,
                IndentChars = "\t",
            };
            var writer = XmlWriter.Create(filepath, settings);
            serializer.WriteObject(writer, serializableObject);
            writer.Close();
        }
    }
}
