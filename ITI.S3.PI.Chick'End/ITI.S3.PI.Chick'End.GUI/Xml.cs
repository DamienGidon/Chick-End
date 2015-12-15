using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace ITI.S3.PI.Chick_End.GUI
{
    public class Xml
    {
        public string Score { get; set; }

        public string Pseudo { get; set; }

        public string Level { get; set; }

        public void Save(string fileName)
        {
            //using (var stream = new FileStream(fileName, FileMode.Create))
            using (var stream = new StreamWriter(fileName, true))
            {
                var XML = new XmlSerializer(typeof(Xml));
                XML.Serialize(stream, this);

            }
        }

        public static Xml LoadFromFile(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                var XML = new XmlSerializer(typeof(Xml));
                return (Xml) XML.Deserialize(stream);
            }
        }
    }
}
