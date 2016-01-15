using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace ITI.S3.PI.Chick_End.GUI
{
    public class Result
    {
        public string ScoreR { get; set; }

        public string PseudoR { get; set; }

        public string LevelR { get; set; }
    }

    public class Xml
    {
        public string Score { get; set; }

        public string Pseudo { get; set; }

        public string Level { get; set; }

        public void Save(string fileName)
        {
            List<Result> _results = new List<Result>();
            Result r = new Result(){ ScoreR = Score, PseudoR = Pseudo, LevelR = Level};
            _results.Add(r);

            if (File.Exists(fileName))
            {
                // ON DESERIALISE
                List<Result> Xml = LoadFromFile("leaderboard.xml");
                foreach(Result element in Xml)
                {
                    _results.Add(element);
                }

                // ON ENREGISTRE
                using (var stream = new FileStream(fileName, FileMode.Open))
                {
                    var XML = new XmlSerializer(typeof(List<Result>));
                    XML.Serialize(stream, _results);
                }
            }
            else
            {
                using (var stream = new FileStream(fileName, FileMode.Create))
                {
                    var XML = new XmlSerializer(typeof(List<Result>));
                    XML.Serialize(stream, _results);
                }
            }
        }

        public static List<Result> LoadFromFile(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                var XML = new XmlSerializer(typeof(List<Result>));
                return (List<Result>) XML.Deserialize(stream);
            }
        }
    }
}
