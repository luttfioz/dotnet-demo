using System;
using System.IO;
using System.Xml.Serialization;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.DeserializeObject("assets/sadeceyazi_53.xml");
        }
        private void DeserializeObject(string filename)
        { 
            Console.WriteLine("Reading with Stream");
            // XmlSerializer instance'sı yaratılır.
            XmlSerializer serializer = new XmlSerializer(typeof(Template));
            // deserialize edilecek Template objesi tanımlanır.
            Template xml_template;

            // using kullanarak disposable Stream objesi ile xml dosyası okunur.
            using (Stream reader = new FileStream(filename, FileMode.Open))
            {
                // Deserialize methodu cagirilir.
                xml_template = (Template)serializer.Deserialize(reader);          
            }
            
            // console'a yazilir.
            Console.WriteLine(xml_template.ToString());
        }
    }
}
