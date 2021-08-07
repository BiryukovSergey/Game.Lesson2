using System.IO;

namespace Controller
{
    public class StreamData : IData<SaveData>
    {
        public void Save(SaveData data, string path = null)
        {
            if(path == null) return;
            using (var sw = new StreamWriter(path))
            {
                sw.WriteLine(data.Name);
                sw.WriteLine(data.Position.X);
                sw.WriteLine(data.Position.Y);
                sw.WriteLine(data.Position.Z);
                sw.WriteLine(data.IsEnabled);
            }
        }

        public SaveData Load(string path = null)
        {
            bool test;
            var result = new SaveData();
            using (var sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    result.Name = sr.ReadLine();
                    result.Position.X = float.Parse(sr.ReadLine());
                    result.Position.Y = float.Parse(sr.ReadLine());
                    result.Position.Z = float.Parse(sr.ReadLine());
                    result.IsEnabled = bool.TryParse(sr.ReadLine(),out test);
                }
            }
            return result;
        }
    }
}