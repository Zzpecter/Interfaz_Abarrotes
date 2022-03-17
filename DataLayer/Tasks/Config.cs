using Newtonsoft.Json;

namespace DataLayer.Tasks
{
    public class Config
    {
        public void readURL()
        {
            string fullPath = Path.GetFullPath(@"..\..\..\..\DataLayer\config.json");
            Models.Config cfg = JsonConvert.DeserializeObject<Models.Config>(File.ReadAllText(fullPath));
            Globals.API_URL = cfg.API_URL;
        }
    }
}
